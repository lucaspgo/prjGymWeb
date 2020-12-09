using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjCapeloWeb.Models;

namespace prjCapeloWeb.Controllers
{
    public class PessoaController : Controller
    {
        private readonly Context _context;
        private readonly UserManager<Pessoa> _userManager;
        private readonly SignInManager<Pessoa> _singInManager;

        public PessoaController(Context context, UserManager<Pessoa> userManager, SignInManager<Pessoa> singInManager)
        {
            _context = context;
            _userManager = userManager;
            _singInManager = singInManager;
        }

        // GET: Pessoa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoas.ToListAsync());
        }

        // GET: Pessoa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pessoaView = await _context.Pessoas
                .FirstOrDefaultAsync(m => m.Id.Equals(id));
            if (pessoaView == null)
            {
                return NotFound();
            }

            return View(pessoaView);
        }

        // GET: Pessoa/Create
        public IActionResult Create()
        {            
            return View();
        }

        // POST: Pessoa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Email,Senha,Id,CriadoEm,ConfirmacaoSenha")] PessoaView pessoaView)
        {
            Pessoa pessoa = new Pessoa
            {
                UserName = pessoaView.Email,
                Email = pessoaView.Email
            };

            IdentityResult resultado = await _userManager.CreateAsync(pessoa, pessoaView.Senha);
            if (resultado.Succeeded)
            {   
                return RedirectToAction(nameof(Index));
            }
            AdicionarErros(resultado);
            //if (ModelState.IsValid)
            //{
                
            //}
            return View(pessoaView);
        }

        public void AdicionarErros(IdentityResult resultado)
        {
            foreach (IdentityError erro in resultado.Errors)
            {
                ModelState.AddModelError("", erro.Description);
            }
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("")] PessoaView pessoaView)
        {
            var result = await _singInManager.PasswordSignInAsync(pessoaView.Email, pessoaView.Senha, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Ficha");
            }

            ModelState.AddModelError("", "Login ou senha inválidos!");
            return View(pessoaView);
            
        }

        public async Task<IActionResult> Logout()
        {
            await _singInManager.SignOutAsync();
            return RedirectToAction("Login", "Pessoa");
        }

    }
}

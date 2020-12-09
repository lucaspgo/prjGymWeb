using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCapeloWeb.DAL;
using prjCapeloWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Controllers
{
    //[Authorize(Roles = "ADM")] //Roles é as regras pra quem pode acessar    
    //[Authorize] //Roles é as regras pra quem pode acessar    
    //[AllowAnonymous] permite
    public class DisciplinaController : Controller
    {
        ////getbootstrap
        ////bootswatch
        ////www.w3schools.com/bootstrap4/default.asp
        //private readonly DisciplinaDAO _disciplinaDAO;
        //public DisciplinaController(DisciplinaDAO disciplinaDAO) => _disciplinaDAO = disciplinaDAO;

        //public IActionResult Index()
        //{
        //    List<Disciplina> disciplinas = _disciplinaDAO.Listar();
        //    ViewBag.Quantidade = disciplinas.Count;
        //    ViewBag.Title = "Gerenciamento de Disciplinas";
        //    return View(disciplinas);
        //}
        //public IActionResult Cadastrar()
        //{
        //    ViewBag.Title = "Cadastrar de Disciplinas";
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Cadastrar(Disciplina disciplina)
        //{
        //    if (_disciplinaDAO.Cadastrar(disciplina))
        //    {
        //        return RedirectToAction("Index", "Disciplina"); //Index, Controller
        //    }
        //    ModelState.AddModelError("", "Não foi possível cadastrar a disciplina! Já existe uma disciplina com o mesmo nome ou sigla no sistema!");
        //    return View(disciplina);
        //}

        //public IActionResult Remover(int id)
        //{
        //    _disciplinaDAO.Remover(id);
        //    return RedirectToAction("Index", "Disciplina");
        //}

        //public IActionResult Alterar(int id)
        //{
        //    //ViewBag.Disciplina = _disciplinaDAO.BuscarPorId(id);

        //    return View(_disciplinaDAO.BuscarPorId(id));
        //}

        //[HttpPost]
        //public IActionResult Alterar(Disciplina disciplina)
        //{
        //    _disciplinaDAO.Alterar(disciplina);

        //    return RedirectToAction("Index", "Disciplina"); //Index, Controller
        //}
    }
}

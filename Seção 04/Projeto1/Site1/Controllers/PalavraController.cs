﻿using Microsoft.AspNetCore.Mvc;
using Site1.Database;
using Site1.Library.Filters;
using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Site1.Controllers {

    [Login]
    public class PalavraController : Controller {

        private DatabaseContext _db;

        public PalavraController(DatabaseContext db) {
            _db = db;
        }

        //Listar todas as palavras do banco de dados
        public IActionResult Index(int? page) {
            var pageNumber = page ?? 1;

            var palavras = _db.Palavras.ToList();
            var resultadoPaginado = palavras.ToPagedList(pageNumber, 5);

            return View(resultadoPaginado);
        }

        //CRUD - Cadastrar, Consultar, Atualizar e Excluir. (Create, Reatrieve, Updade, Delete - CRUD)
        [HttpGet]
        public IActionResult Cadastrar() {
            return View(new Palavra());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra) {

            if (ModelState.IsValid) {
                _db.Palavras.Add(palavra);
                _db.SaveChanges();

                TempData["Mensagem"] = "A palavra "+palavra.Nome+" foi cadastrada com sucesso!";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id) {
            Palavra palavra = _db.Palavras.Find(Id);

            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra) {
            if (ModelState.IsValid) {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();

                TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi atualizada com sucesso!";

                return RedirectToAction("Index");
            }
            return View("Cadastrar", palavra);
        }

        //Palavra/Excluir/391
        //{controller}/{Action}/{Id?}
        [HttpGet]
        public IActionResult Excluir(int Id) {

            Palavra palavra = _db.Palavras.Find(Id);
            //TODO - EXCLUIR REGISTRO NO BANCO
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();

            TempData["Mensagem"] = "A palavra " + palavra.Nome + " foi excluida com sucesso!";

            return RedirectToAction("Index");
        }


    }
}

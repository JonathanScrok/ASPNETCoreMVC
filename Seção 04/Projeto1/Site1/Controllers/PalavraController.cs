﻿using Microsoft.AspNetCore.Mvc;
using Site1.Database;
using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Controllers {
    public class PalavraController : Controller {

        private DatabaseContext _db;

        public PalavraController(DatabaseContext db) {
            _db = db;
        }

        //Listar todas as palavras do banco de dados
        public IActionResult Index() {
            ViewBag.Palavras = _db.Palavras.ToList();
            return View();
        }

        //CRUD - Cadastrar, Consultar, Atualizar e Excluir. (Create, Reatrieve, Updade, Delete - CRUD)
        [HttpGet]
        public IActionResult Cadastrar() {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm]Palavra palavra) {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar() {
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra) {
            return View("Cadastrar");
        }

        //Palavra/Excluir/391
        //{controller}/{Action}/{Id?}
        [HttpGet]
        public IActionResult Excluir(int Id) {

            //TODO - EXCLUIR REGISTRO NO BANCO
            return RedirectToAction("Index");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Database;

namespace Test.Controllers
{
    public class BookController : Controller
    {
        // Phuong thuc list (xem tat ca sach) 
        public ActionResult Index()
        {
            using (var db = new DbContext())
            {
                //Lay het tat ca Book co trong csdl
                var books = db.Sach.Where(p=>!p.isDeleted).ToList();    
                //Tra ve view
                return View(books);
            }    
        }

    
        //Phuong thuc create, Cho nay la GET method
        public ActionResult Create()
        {
            //Tra ve view ten la "Create" khi goi "localhost:49897/Book/Create"
            return View();
        }

        //Phuong thuc Post Create (Sau khi click button xac nhan)
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "id")]Sach newBook)
        {
            try
            {
                using (var db = new DbContext())
                {
                    //Them sach moi vao csdl
                    db.Sach.Add(newBook);
                    db.SaveChanges();
                    //Tra ve view Index de xem sach da them
                    return RedirectToAction("Index");
                }     
            }
            catch
            {
                return View();
            }
        }

        //Phuong thuc Edit, method GET (Lay Book can edit thong qua id)
        public ActionResult Edit(int id)
        {
            using (var db = new DbContext())
            {
                //Lay book theo id
                var sach = db.Sach.Select(b => b).Where(b => b.id == id).FirstOrDefault();
                //Tra ve view Edit
                return View(sach);
            }              
        }

        //Phuong thuc Edit, sau khi da lay duoc sach thong qua id
        [HttpPost]
        public ActionResult Edit(Sach editedBook)
        {
            try
            {
                using (var db = new DbContext())
                {
                    //Edit tung property
                    var book = db.Sach.Select(p => p).Where(p => p.id == editedBook.id).FirstOrDefault();
                    book.TenSach = editedBook.TenSach;
                    book.SoTrang = editedBook.SoTrang;
                    book.GiaSach = editedBook.GiaSach;
                    book.MoTa = editedBook.MoTa;
                    book.isDeleted = editedBook.isDeleted;
                    book.TenTacGia = editedBook.TenTacGia;
                    book.SoLuongXem = editedBook.SoLuongXem;
                    book.SoLuongConLai = editedBook.SoLuongConLai;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        
        //Tao di coi phim
        public ActionResult Delete(int id)
        {
            using (var db = new DbContext())
            {
                var book = db.Sach.Select(p => p).Where(p => p.id == id).FirstOrDefault();
                return View(book);
            }
                
        }

        
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (var db = new DbContext())
                {
                    var sach = db.Sach.Select(p => p).Where(p => p.id == id).FirstOrDefault();
                    if (sach != null)
                        sach.isDeleted = true;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

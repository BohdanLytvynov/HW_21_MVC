using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ORM;
using HW21_MVC.ViewModel;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HW21_MVC.Controllers
{
    public class HomeController : Controller
    {        
        string title = "Home";//title of web page

        string action = String.Empty; //name of function

        private IRepository m_rep; //repository will be used after DI
        
        List<string> errors;//Erroe List
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="rep"></param>
        public HomeController(IRepository rep) 
        {
            m_rep = rep;

            errors = new List<string>();
        }
        /// <summary>
        /// Will send html representation of init page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {            
            title = "Home";

            action = "Notes Viewer";
            
            ViewData.Add("NotesCol", m_rep.GetNotes());

            ViewData.Add("ActionType", action);

            return View("Index", title);
        }
        /// <summary>
        /// Will send add page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Add()
        {
            title = "Add Note";

            action = "Add Note Function";

            ViewData["ActionType"] = action;

            return View("Add", title);
        }
        /// <summary>
        /// Will send info page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Info()
        {
            Guid id = GetIdFromRequest();

            Notes note = m_rep.GetNoteById(id);
            
            ViewData.Add("sNote", note);

            title = "Aditional Info";

            ViewData["ActionType"] = title;

            return View("Info", title);
        }

        /// <summary>
        /// Will add note to db and send result page
        /// </summary>
        /// <param name="noteVm"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddNote(NoteVM noteVm)
        {
            title = "Add Result";

            action = "Add Result Info";

            ViewData["ActionType"] = action;

            ViewData.Add("operType", 1);

            ViewData.Add("OperRes", null);
            
            if (ModelState.IsValid)
            {
                m_rep.AddNote(
                new Notes(Guid.NewGuid(), noteVm.Surename,
                noteVm.Name,
                noteVm.Lastname,
                noteVm.Phone,
                noteVm.Adress,
                noteVm.Description)
                );

                ViewData["OperRes"] = true;
            }
            else
            {
                ViewData["OperRes"] = false;

                ParseErrors(ModelState.Values.ToList());                                
            }

            return View("AddNoteResult", title);

        }

        [HttpGet]
        public IActionResult RemoveNote()
        {
            title = "Operation result";

            action = "Operation {Remove Note} Result:";
            ViewData.Add("ActionType", action);
            Guid Id = GetIdFromRequest();

            ViewData.Add("OperRes", null);
            try
            {
                m_rep.RemoveNote(Id);
                ViewData["OperRes"] = true;
            }
            catch (Exception)
            {
                ViewData["OperRes"] = false;                
            }

            ViewData.Add("operType", 3);
                        
            return View("AddNoteResult", title);
        }

        [HttpPost]
        public IActionResult EditNote(NoteVM newNote)
        {
            title = "Operation Result";

            action = "Operation Edit Note Result:";
            ViewData.Add("ActionType", action);

            ViewData.Add("operType", 2);

            ViewData.Add("OperRes", null);

            Guid id = GetIdFromRequest();

            try
            {
                m_rep.EditNote(id, new Notes(
                    id, newNote.Surename, newNote.Name,
                    newNote.Lastname, newNote.Phone, newNote.Adress,
                    newNote.Description
                    ));

                ViewData["OperRes"] = true;
            }
            catch (Exception)
            {
                ViewData["OperRes"] = false;
            }

            return View("AddNoteResult", title);
        }

        /// <summary>
        /// Gets Id from request
        /// </summary>
        /// <returns></returns>
        private Guid GetIdFromRequest()=>        
            Guid.Parse(HttpContext.Request.Path.Value.Split('=')[1]);

        private void ParseErrors(List<ModelStateEntry> errorsEntry)
        {
            foreach (var item in errorsEntry)
            {
                foreach (var eror in item.Errors)
                {
                    errors.Add(eror.ErrorMessage);
                }
            }

            ViewData.Add("Errors", errors);
        }
        

    }
}

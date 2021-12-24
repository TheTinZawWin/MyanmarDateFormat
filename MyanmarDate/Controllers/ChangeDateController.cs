using MyanmarDate.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyanmarDate.Controllers
{
    public class ChangeDateController : Controller
    {
        // GET: ChangeDate
        public ActionResult Index()
        {
            DateTime date = DateTime.Now;
           
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            string monthName = date.ToString("MMMM", CultureInfo.CreateSpecificCulture("en-us"));
            string monthMM = string.Empty;
            
            switch (monthName)
            {
                case "January":
                    monthMM = "ဇန်နဝါရီ";
                    break;

                case "February":
                    monthMM = "ဖေဖော်ဝါရီ";
                    break;
                case "March":
                    monthMM = "မတ်";
                    break;
                case "April":
                    monthMM = "ဧပြီ";
                    break;
                case "May":
                    monthMM = "မေ";
                    break;
                case "June":
                    monthMM = "ဇွန်";
                    break;
                case "July":
                    monthMM = "ဇူလိုင်";
                    break;
                case "August":
                    monthMM = "ဩဂုတ်";
                    break;
                case "September":
                    monthMM = "စက်တင်ဘာ";
                    break;
                case "October":
                    monthMM = "အောက်တိုဘာ";
                    break;

                case "November":
                    monthMM = "နိုဝင်ဘာ";
                    break;

                case "December":
                    monthMM = "ဒီဇင်ဘာ";
                    break;

                default:
                    break;
            }
            var mmyear = year.ToString().ConvertNumerals(CultureInfo.GetCultureInfo("my-MM"));
            //var mmmonth= month.ToString().ConvertNumerals(CultureInfo.GetCultureInfo("my-MM"));
            var mmday = day.ToString().ConvertNumerals(CultureInfo.GetCultureInfo("my-MM"));

            string dateTime = "ရက်စွဲ ။        " + mmyear + "ခုနှစ် ၊ " + monthMM + "လ ၊ (" + mmday + ")ရက်။";
            //new
            DateDataModel dataModel = new DateDataModel();
            dataModel.date = date;
            dataModel.engDate = date.ToString("dd MMM yyyy");
            dataModel.engDateTime = date.ToString("dd MMM yyyy HH:mm");
            dataModel.myanmarDate = dateTime;
            return View(dataModel);
        }
    }
}
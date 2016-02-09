namespace Calculator.Controllers
{
    using System;
    using System.Web.Mvc;
    using Calculator.Models;
    using System.Collections.Generic;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostData(RequestDataModel model)
        {
            var quantity = model.Quantity;
            var typeNum = (int)model.Type;
            int kilo = model.Kilo;

            var bitResult = quantity;
            var byteResult = quantity;

            if (typeNum % 2 == 0)
            {
                //here is bit
                for (int i = 0; i < typeNum / 2; i++)
                {
                    bitResult = bitResult * kilo;
                }

                byteResult = quantity / 8;

                for (int i = 0; i < typeNum / 2; i++)
                {
                    byteResult = byteResult * kilo;
                }

                Calculate(bitResult, bitResult / 8, kilo);
            }
            else
            {
                //here is byte
                for (int i = 0; i < typeNum / 2; i++)
                {
                    byteResult = byteResult * kilo;
                }

                bitResult = quantity * 8;

                for (int i = 0; i < typeNum / 2; i++)
                {
                    bitResult = bitResult * kilo;
                }
                Calculate(bitResult, byteResult, kilo);
            }

            return View("Index");
        }

        private void Calculate(double Bit, double Byte, int kilo)
        {
            var result = new Dictionary<string, double>();

            result.Add("b", Bit);
            result.Add("B", Byte);
            result.Add("Kb", (result["b"] / kilo));
            result.Add("KB", (result["B"] / kilo));
            result.Add("Mb", (result["Kb"] / kilo));
            result.Add("MB", (result["KB"] / kilo));
            result.Add("Gb", (result["Mb"] / kilo));
            result.Add("GB", (result["MB"] / kilo));
            result.Add("Tb", (result["Gb"] / kilo));
            result.Add("TB", (result["GB"] / kilo));
            result.Add("Pb", (result["Tb"] / kilo));
            result.Add("PB", (result["TB"] / kilo));
            result.Add("Eb", (result["Pb"] / kilo));
            result.Add("EB", (result["PB"] / kilo));
            result.Add("Zb", (result["Eb"] / kilo));
            result.Add("ZB", (result["EB"] / kilo));
            result.Add("Yb", (result["Zb"] / kilo));
            result.Add("YB", (result["ZB"] / kilo));

            ViewBag.Result = result;
        }
    }
}
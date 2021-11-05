using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoBT.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace ProjetoBT.Controllers
{
    public class ProcessosController : Controller
    {
        
        public ActionResult Index()
        {
            try
            {
                VMProcessosIndex vmProcessosIndex = new VMProcessosIndex();

                VMProcessosIndexItem vmProcessosIndexItem = new VMProcessosIndexItem();

                vmProcessosIndexItem.iProcesso = 1231;
                vmProcessosIndexItem.dValorCausa = Convert.ToDecimal(50000);
                vmProcessosIndexItem.sNomeContratante = "Teste";
                vmProcessosIndexItem.sNomeEscritório = "Casa do Teste";
                vmProcessosIndexItem.bAprovarCausa = false;

                vmProcessosIndex.ListaProcessos.Add(vmProcessosIndexItem);

                return View(vmProcessosIndex);
            }
            catch(SystemException ex)
            {
                throw;
            }
        }

        public ActionResult Forms(int iProcesso)
        {
            VMProcessosForms vmProcessosForms = new VMProcessosForms();

            return View(vmProcessosForms);
        }

        [HttpPost]
        public JsonResult Forms(VMProcessosForms vmProcessosForms)
        {

            return Json(new { Resultado = 1, Mensagem = "Sucesso" });
        }

    }

}

using Microsoft.AspNetCore.Mvc;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz.stuff7;
using uncode.web.src.Main.CSharp.com.corelogic.darkcode.pantz.stuff7.wtf;


using System.Threading.Tasks;

namespace uncode.web.src.Main.CSharp.com.corelogic.darkcode.web.controllers
{
    [AutoWired]
    public class HomeController : BriansPantz<chaps<Assless>>
    {

        // [Route("[controller]/Get")]
        // [HttpPost]
        // public async Task<HttpErrorCode> helloHell (HttpErrorCode uhOhSpaghettios, FormData form){
        //     return new BrianzPants(form);
        // }
        // this is part of the game don't delete me...

        [Route("[controller]/Get")]
        [HttpPost]
        public async Task<var> helloHell (var var){
            return await var.getDaDude(var);
        }

    }
}
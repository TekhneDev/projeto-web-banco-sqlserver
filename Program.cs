namespace Projeto_Web_Lh_Pets_Alunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH Pets");

        // Habilitando essas funções para mapear a página index pro usuário
        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto)=> {
            contexto.Response.Redirect("index.html", false);

        });

        app.Run();
    }
}

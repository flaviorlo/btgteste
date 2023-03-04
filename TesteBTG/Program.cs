
using System.Data;
using TesteBTG;

namespace TestBTG
{
    class program
    {
        static void Main()
        {

            string tipo = "Papel";
            DataTable dtb = new DataTable();
            dtb.Columns.Add("tipo");
            dtb.Columns.Add("descricao");

            dtb.Rows.Add("Tesoura", "Tesoura vence papel");
            dtb.Rows.Add("Pedra", "Pedra vence tesoura");
            dtb.Rows.Add("Papel", " papel vence pedra");

            var query = from dados in dtb.AsEnumerable()
                        where dados.Field<string>("tipo") == tipo
                        select new
                        {
                            descricao=dados.Field<string>("descricao")
                        };

            Console.WriteLine("Item carregado : " + query.First().descricao);
        } 

    }
}
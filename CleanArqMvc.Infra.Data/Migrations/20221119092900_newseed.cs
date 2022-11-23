using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArqMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class newseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                "VALUES('Caderno espiral','Caderno espiral 100 folhas',7.45,50,'caderno1.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
                   "VALUES('Borracha','Borracha',7.45,50,'Borracha.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
               "VALUES('estojo','estojo',7.45,50,'estojo.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
               "VALUES('mochila','mochila',7.45,50,'mochila.jpg',1)");

            mb.Sql("INSERT INTO Products(Name,Description,Price,Stock,Image,CategoryId)" +
               "VALUES('apontador','apontador',7.45,50,'apontador.jpg',1)");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Products");
        }
    }
}

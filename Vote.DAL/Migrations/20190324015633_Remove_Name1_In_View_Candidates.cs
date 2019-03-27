using Microsoft.EntityFrameworkCore.Migrations;

namespace Vote.DAL.Migrations
{
    public partial class Remove_Name1_In_View_Candidates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var view = @"ALTER VIEW [dbo].[CandidateVotes]
                         AS
                         SELECT c.Id,
	                            c.Name,
	                            c.Bio,
	                            c.Anime,
	                            c.ProfilePhoto,
	                            COUNT(v.id) as Votes
                        FROM [dbo].[Candidates] c
                        LEFT JOIN [dbo].[Votes] v ON v.CandidateId = c.Id
                        GROUP BY  c.Id, c.Name, c.Bio, c.Anime, c.ProfilePhoto";
            migrationBuilder.Sql(view);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW [dbo].[CandidateVotes]");
        }
    }
}

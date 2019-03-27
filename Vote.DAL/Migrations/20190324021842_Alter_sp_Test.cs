using Microsoft.EntityFrameworkCore.Migrations;

namespace Vote.DAL.Migrations
{
    public partial class Alter_sp_Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var view = @"
-- =============================================
-- Author:		RPD
-- Create date: 3.24.2019
-- Description:	For Stored Proc Code First Test
-- =============================================
ALTER PROCEDURE [dbo].[sp_test]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[CandidateVotes]
END";
            migrationBuilder.Sql(view);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE [dbo].[sp_test]");
        }
    }
}

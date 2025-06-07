namespace WordleFormGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddFeedbackToGuesses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guesses", "Feedback", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Guesses", "Feedback");
        }
    }
}

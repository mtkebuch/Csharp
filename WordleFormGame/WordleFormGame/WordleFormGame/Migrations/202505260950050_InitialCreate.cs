namespace WordleFormGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoundId = c.Int(nullable: false),
                        Word = c.String(),
                        AttemptNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rounds", t => t.RoundId, cascadeDelete: true)
                .Index(t => t.RoundId);
            
            CreateTable(
                "dbo.Rounds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerId = c.Int(nullable: false),
                        CorrectWord = c.String(),
                        AttemptsUsed = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        GamesPlayed = c.Int(nullable: false),
                        WinPercentage = c.Int(nullable: false),
                        MaxWinStreak = c.Int(nullable: false),
                        CurrentWinStreak = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Guesses", "RoundId", "dbo.Rounds");
            DropForeignKey("dbo.Rounds", "PlayerId", "dbo.Players");
            DropIndex("dbo.Rounds", new[] { "PlayerId" });
            DropIndex("dbo.Guesses", new[] { "RoundId" });
            DropTable("dbo.Players");
            DropTable("dbo.Rounds");
            DropTable("dbo.Guesses");
        }
    }
}

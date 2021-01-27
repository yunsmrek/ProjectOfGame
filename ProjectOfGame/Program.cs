using ProjectOfGame.Entities;
using ProjectOfGame.Abstract;
using ProjectOfGame.Concrete;
using System;

namespace ProjectOfGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player() { Id = 1, NationalityId = "11111111111", FirstName = "Yunus", LastName = "Kılıç", DateOfBirth = new DateTime(1998,8,17) };
            Player player2 = new Player() { Id = 1, NationalityId = "22222222222", FirstName = "Ömer", LastName = "Gençkan", DateOfBirth = new DateTime(1998, 1, 14) };
            Player player3 = new Player() { Id = 1, NationalityId = "33333333333", FirstName = "Ahmet", LastName = "Bayav", DateOfBirth = new DateTime(1998, 4, 24) };
           
            IPlayerService playerManager = new PlayerManager();
            
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

            Game game1 = new Game() {  Name = "Call Of Duty", Price = 450 };
            Game game2 = new Game() {  Name = "Watch Dogs 2", Price = 280 };
            Game game3 = new Game() {  Name = "Need For Speed Run", Price = 320 };
            
            IGameService gameManager = new GameManager();
            
            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            Campaign campaign1 = new Campaign() {  Name = "Campaign1", StartDate = 2020, EndDate = 2022 };
            Campaign campaign2 = new Campaign() {  Name = "Campaign2", StartDate = 2020, EndDate = 2021 };
            Campaign campaign3 = new Campaign() {  Name = "Campaign3", StartDate = 2021, EndDate = 2022 };
            
            ICampaignService campaignServices = new CampaignManager();
            
            campaignServices.Add(campaign1);
            campaignServices.Add(campaign2);
            campaignServices.Add(campaign3);
           
            gameManager.SellGame(game1, player1, campaign1);
            gameManager.SellGame(game2, player2, campaign2);
            gameManager.SellGame(game3, player3, campaign3);

        }
    }
}

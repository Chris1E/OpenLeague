namespace OpenLeague.Persistence
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using OpenLeague.Model.Entities;

    public class OpenLeagueDbInitializer : DropCreateDatabaseIfModelChanges<OpenLeagueDbContext>
    {
        protected override void Seed(OpenLeagueDbContext context)
        {
            var playerChrisShallcross = new Player { Id = Guid.NewGuid(), Name = "Chris Shallcross", Username = @"1E\Chris.Shallcross", PictureUrl = "http:/tbd/ChrisShallcross.jpg" };
            var playerCosminOnea = new Player { Id = Guid.NewGuid(), Name = "Cosmin Onea", Username = @"1E\Cosmin.Onea", PictureUrl = "http:/tbd/CosminOnea.jpg" };
            var playerDeepthiDaita = new Player { Id = Guid.NewGuid(), Name = "Deepthi Daita", Username = @"1E\Deepthi.Daita", PictureUrl = "http:/tbd/DeepthiDaita.jpg" };
            var playerManishKulkarni = new Player { Id = Guid.NewGuid(), Name = "Manish Kulkarni", Username = @"1E\Manish.Kulkarni", PictureUrl = "http:/tbd/ManishKulkarni.jpg" };
            var playerPaulAston = new Player { Id = Guid.NewGuid(), Name = "Paul Aston", Username = @"1E\Paul.Aston", PictureUrl = "http:/tbd/PaulAston.jpg" };
            var playerSumantaSarkar = new Player { Id = Guid.NewGuid(), Name = "Sumanta Sarkar", Username = @"1E\Sumanta.Sarkar", PictureUrl = "http:/tbd/SumantaSarkar.jpg" };
            var playerEdSykes = new Player { Id = Guid.NewGuid(), Name = "Ed Sykes", Username = @"1E\Edward.Sykes", PictureUrl = "http:/tbd/EdSykes.jpg" };
            var playerFredKasadha = new Player { Id = Guid.NewGuid(), Name = "Fred Kasadha", Username = @"1E\FredK", PictureUrl = "http:/tbd/FredKasadha.jpg" };
            var playerLaxHirani = new Player { Id = Guid.NewGuid(), Name = "Lax Hirani", Username = @"1E\Lax.Hirani", PictureUrl = "http:/tbd/LaxHirani.jpg" };
            var playerMagdalenaMackow = new Player { Id = Guid.NewGuid(), Name = "Magdalena Mackow", Username = @"1E\Magdalena.Mackow", PictureUrl = "http:/tbd/MagdalenaMackow.jpg" };
            var playerChintanGupta = new Player { Id = Guid.NewGuid(), Name = "Chintan Gupta", Username = @"1E\Chintan.Gupta", PictureUrl = "http:/tbd/ChintanGupta.jpg" };
            var playerGokulRaju = new Player { Id = Guid.NewGuid(), Name = "Gokul Raju", Username = @"1E\Gokul.Raju", PictureUrl = "http:/tbd/GokulRaju.jpg" };
            var playerMarkJones = new Player { Id = Guid.NewGuid(), Name = "Mark Jones", Username = @"1E\Mark.Jones", PictureUrl = "http:/tbd/MarkJones.jpg" };
            var playerSatoshiNakane = new Player { Id = Guid.NewGuid(), Name = "Satoshi Nakane", Username = @"1E\Satoshi.Nakane", PictureUrl = "http:/tbd/SatoshiNakane.jpg" };
            var playerSushilKarwa = new Player { Id = Guid.NewGuid(), Name = "Sushil Karwa", Username = @"1E\Sushil.Karwa", PictureUrl = "http:/tbd/SushilKarwa.jpg" };
            var playerEmilianFilip = new Player { Id = Guid.NewGuid(), Name = "Emilian Filip", Username = @"1E\Emilian.Filip", PictureUrl = "http:/tbd/EmilianFilip.jpg" };
            var playerAndrewBishop = new Player { Id = Guid.NewGuid(), Name = "Andrew Bishop", Username = @"1E\Andrew.Bishop", PictureUrl = "http:/tbd/AndrewBishop.jpg" };
            var playerClementUnyereno = new Player { Id = Guid.NewGuid(), Name = "Clement Unyereno", Username = @"1E\Clement.Unyereno", PictureUrl = "http:/tbd/ClementUnyereno.jpg" };
            var playerRichardCudd = new Player { Id = Guid.NewGuid(), Name = "Richard Cudd", Username = @"1E\RichardC", PictureUrl = "http:/tbd/RichardCudd.jpg" };
            var playerSophieChang = new Player { Id = Guid.NewGuid(), Name = "Sophie Chang", Username = @"1E\sophiec", PictureUrl = "http:/tbd/SophieChang.jpg" };
            var playerStevanLukic = new Player { Id = Guid.NewGuid(), Name = "Stevan Lukic", Username = @"1E\Stevan.Lukic", PictureUrl = "http:/tbd/StevanLukic.jpg" };
            var playerSteveCoates = new Player { Id = Guid.NewGuid(), Name = "Steve Coates", Username = @"1E\Steve.Coates", PictureUrl = "http:/tbd/SteveCoates.jpg" };
            var playerBarryOHalloran = new Player { Id = Guid.NewGuid(), Name = "Barry OHalloran", Username = @"1E\Barry.OHalloran", PictureUrl = "http:/tbd/BarryOHalloran.jpg" };
            var playerPaulBateman = new Player { Id = Guid.NewGuid(), Name = "Paul Bateman", Username = @"1E\Paul.Bateman", PictureUrl = "http:/tbd/PaulBateman.jpg" };
            var playerVishalLadwa = new Player { Id = Guid.NewGuid(), Name = "Vishal Ladwa", Username = @"1E\Vishal.Ladwa", PictureUrl = "http:/tbd/VishalLadwa.jpg" };
            var playerBrendanClarke = new Player { Id = Guid.NewGuid(), Name = "Brendan Clarke", Username = @"1E\Brendan.Clarke", PictureUrl = "http:/tbd/BrendanClarke.jpg" };
            var playerDerekHartung = new Player { Id = Guid.NewGuid(), Name = "Derek Hartung", Username = @"1E\Derekh", PictureUrl = "http:/tbd/DerekHartung.jpg" };
            var playerEmmaObichukwu = new Player { Id = Guid.NewGuid(), Name = "Emma Obichukwu", Username = @"1E\Emma.Obichukwu", PictureUrl = "http:/tbd/EmmaObichukwu.jpg" };
            var playerSimonWoods = new Player { Id = Guid.NewGuid(), Name = "Simon Woods", Username = @"1E\Simon.Woods", PictureUrl = "http:/tbd/SimonWoods.jpg" };
            var playerHenryTruong = new Player { Id = Guid.NewGuid(), Name = "Henry Truong", Username = @"1E\Henry.Truong", PictureUrl = "http:/tbd/HenryTruong.jpg" };
            var playerDevenPatel = new Player { Id = Guid.NewGuid(), Name = "Deven Patel", Username = @"1E\Deven.Patel", PictureUrl = "http:/tbd/DevenPatel.jpg" };
            var playerSachinPatel = new Player { Id = Guid.NewGuid(), Name = "Sachin Patel", Username = @"1E\Sachinp", PictureUrl = "http:/tbd/SachinPatel.jpg" };
            var playerDavidFollant = new Player { Id = Guid.NewGuid(), Name = "David Follant", Username = @"1E\dfollant", PictureUrl = "http:/tbd/DavidFollant.jpg" };
            var playerPaulGoodson = new Player { Id = Guid.NewGuid(), Name = "Paul Goodson", Username = @"1E\PaulG", PictureUrl = "http:/tbd/PaulGoodson.jpg" };
            var playerPeterMajor = new Player { Id = Guid.NewGuid(), Name = "Peter Major", Username = @"1E\Peter.Major", PictureUrl = "http:/tbd/PeterMajor.jpg" };
            var playerSumirKarayi = new Player { Id = Guid.NewGuid(), Name = "Sumir Karayi", Username = @"1E\SumirK", PictureUrl = "http:/tbd/SumirKarayi.jpg" };
            var playerAldousAntony = new Player { Id = Guid.NewGuid(), Name = "Aldous Antony", Username = @"1E\Aldous.Antony", PictureUrl = "http:/tbd/AldousAntony.jpg" };
            var playerSuKent = new Player { Id = Guid.NewGuid(), Name = "Su Kent", Username = @"1E\Su.Kent", PictureUrl = "http:/tbd/SuKent.jpg" };
            var playerSeemaOommen = new Player { Id = Guid.NewGuid(), Name = "Seema Oommen", Username = @"1E\Seema.Oommen", PictureUrl = "http:/tbd/SeemaOommen.jpg" };
            var playerRajpalSingh = new Player { Id = Guid.NewGuid(), Name = "Rajpal Singh", Username = @"1E\RajpalS", PictureUrl = "http:/tbd/RajpalSingh.jpg" };
            var playerWernerVanderberg = new Player { Id = Guid.NewGuid(), Name = "Werner Vanderberg", Username = @"1E\Werner.Vanderberg", PictureUrl = "http:/tbd/WernerVanderberg.jpg" };
            var playerRipalVaidya = new Player { Id = Guid.NewGuid(), Name = "Ripal Vaidya", Username = @"1E\Ripal.Vaidya", PictureUrl = "http:/tbd/RipalVaidya.jpg" };
            var playerNehaSood = new Player { Id = Guid.NewGuid(), Name = "Neha Sood", Username = @"1E\Neha.Sood", PictureUrl = "http:/tbd/NehaSood.jpg" };
            var playerRebeccaOni = new Player { Id = Guid.NewGuid(), Name = "Rebecca Oni", Username = @"1E\Rebecca.Oni", PictureUrl = "http:/tbd/RebeccaOni.jpg" };
            var playerPlayoffWinner = new Player { Id = Guid.NewGuid(), Name = "Playoff Winner", Username = string.Empty, PictureUrl = "http:/tbd/PlayoffWinner.jpg" };
            var playerPlayoffLoser = new Player { Id = Guid.NewGuid(), Name = "Playoff Loser", Username = string.Empty, PictureUrl = "http:/tbd/PlayoffLoser.jpg" };
            var playerLironSchur = new Player { Id = Guid.NewGuid(), Name = "Liron Schur ", Username = @"1E\Liron.Schur", PictureUrl = "http:/tbd/LironSchur.jpg" };
            var playerVipulAsher = new Player { Id = Guid.NewGuid(), Name = "Vipul Asher", Username = @"1E\Vipul.Asher", PictureUrl = "http:/tbd/VipulAsher.jpg" };
            var playerAdrianTodd = new Player { Id = Guid.NewGuid(), Name = "Adrian Todd", Username = @"1E\Adrian.Todd", PictureUrl = "http:/tbd/AdrianTodd.jpg" };
            var playerDimitraStavrinides = new Player { Id = Guid.NewGuid(), Name = "Dimitra Stavrinides", Username = @"1E\Dimitra.Stavrinides", PictureUrl = "http:/tbd/DimitraStavrinides.jpg" };
            var playerAndyBrand = new Player { Id = Guid.NewGuid(), Name = "Andy Brand", Username = @"1E\Andy.Brand", PictureUrl = "http:/tbd/AndyBrand.jpg" };
            var playerMikeJefferson = new Player { Id = Guid.NewGuid(), Name = "Mike Jefferson", Username = @"1E\Mike.Jefferson", PictureUrl = "http:/tbd/MikeJefferson.jpg" };
            var playerShadrachAyidu = new Player { Id = Guid.NewGuid(), Name = "Shadrach Ayidu", Username = @"1E\Shadrach.Ayidu", PictureUrl = "http:/tbd/ShadrachAyidu.jpg" };
            var playerDaveHarding = new Player { Id = Guid.NewGuid(), Name = "Dave Harding", Username = @"1E\Dave.Harding", PictureUrl = "http:/tbd/DaveHarding.jpg" };
            var playerAgnieszkaKelly = new Player { Id = Guid.NewGuid(), Name = "Agnieszka Kelly", Username = @"1E\Agnieszka.Kelly", PictureUrl = "http:/tbd/AgnieszkaKelly.jpg" };
            var playerChrisBlayney = new Player { Id = Guid.NewGuid(), Name = "Chris Blayney", Username = @"1E\Chris.Blayney", PictureUrl = "http:/tbd/ChrisBlayney.jpg" };
            var playerOliviaWatermeyer = new Player { Id = Guid.NewGuid(), Name = "Olivia Watermeyer", Username = @"1E\Olivia.Watermeyer", PictureUrl = "http:/tbd/OliviaWatermeyer.jpg" };
            var playerAmarKaldate = new Player { Id = Guid.NewGuid(), Name = "Amar Kaldate", Username = @"1E\Amar.Kaldate", PictureUrl = "http:/tbd/AmarKaldate.jpg" };
            var playerBiswaDas = new Player { Id = Guid.NewGuid(), Name = "Biswa Das", Username = @"1E\Biswa.Das", PictureUrl = "http:/tbd/BiswaDas.jpg" };
            var playerAndrewGoodman = new Player { Id = Guid.NewGuid(), Name = "Andrew Goodman", Username = @"1E\Andrew.Goodman", PictureUrl = "http:/tbd/AndrewGoodman.jpg" };
            var playerRetoEgeter = new Player { Id = Guid.NewGuid(), Name = "Reto Egeter", Username = @"1E\Reto.Egeter", PictureUrl = "http:/tbd/RetoEgeter.jpg" };
            var playerScottMcGill = new Player { Id = Guid.NewGuid(), Name = "Scott McGill", Username = @"1E\Scott.McGill", PictureUrl = "http:/tbd/ScottMcGill.jpg" };
            var playerMattAlbert = new Player { Id = Guid.NewGuid(), Name = "Matt Albert", Username = @"1E\Matt.Albert", PictureUrl = "http:/tbd/MattAlbert.jpg" };
            var playerEvinHill = new Player { Id = Guid.NewGuid(), Name = "Evin Hill", Username = @"1E\Evin.Hill", PictureUrl = "http:/tbd/EvinHill.jpg" };
            var playerMatthewLepselter = new Player { Id = Guid.NewGuid(), Name = "Matthew Lepselter", Username = @"1E\Matthew.Lepselter", PictureUrl = "http:/tbd/MatthewLepselter.jpg" };
            var playerCarolineDuffy = new Player { Id = Guid.NewGuid(), Name = "Caroline Duffy", Username = @"1E\Caroline.Duffy", PictureUrl = "http:/tbd/CarolineDuffy.jpg" };
            var playerEricBeller = new Player { Id = Guid.NewGuid(), Name = "Eric Beller", Username = @"1E\Eric.Beller", PictureUrl = "http:/tbd/EricBeller.jpg" };
            var playerDanHudson = new Player { Id = Guid.NewGuid(), Name = "Dan Hudson", Username = @"1E\Dan.Hudson", PictureUrl = "http:/tbd/DanHudson.jpg" };
            var playerOmarAbdeldayem = new Player { Id = Guid.NewGuid(), Name = "Omar Abdeldayem", Username = @"1E\Omar.Abdeldayem", PictureUrl = "http:/tbd/OmarAbdeldayem.jpg" };
            var playerNoraPetrova = new Player { Id = Guid.NewGuid(), Name = "Nora Petrova", Username = @"1E\Nora.Petrova", PictureUrl = "http:/tbd/NoraPetrova.jpg" };
            var playerAshNanda = new Player { Id = Guid.NewGuid(), Name = "Ash Nanda", Username = @"1E\Ash.Nanda", PictureUrl = "http:/tbd/AshNanda.jpg" };
            var playerAnthonyCaw = new Player { Id = Guid.NewGuid(), Name = "Anthony Caw", Username = @"1E\Anthony.Caw", PictureUrl = "http:/tbd/AnthonyCaw.jpg" };
            var playerNikhilKaluskar = new Player { Id = Guid.NewGuid(), Name = "Nikhil Kaluskar", Username = @"1E\Nikhil.Kaluskar", PictureUrl = "http:/tbd/NikhilKaluskar.jpg" };

            context.Players.Add(playerChrisShallcross);
            context.Players.Add(playerCosminOnea);
            context.Players.Add(playerDeepthiDaita);
            context.Players.Add(playerManishKulkarni);
            context.Players.Add(playerPaulAston);
            context.Players.Add(playerSumantaSarkar);
            context.Players.Add(playerEdSykes);
            context.Players.Add(playerFredKasadha);
            context.Players.Add(playerLaxHirani);
            context.Players.Add(playerMagdalenaMackow);
            context.Players.Add(playerChintanGupta);
            context.Players.Add(playerGokulRaju);
            context.Players.Add(playerMarkJones);
            context.Players.Add(playerSatoshiNakane);
            context.Players.Add(playerSushilKarwa);
            context.Players.Add(playerEmilianFilip);
            context.Players.Add(playerAndrewBishop);
            context.Players.Add(playerClementUnyereno);
            context.Players.Add(playerRichardCudd);
            context.Players.Add(playerSophieChang);
            context.Players.Add(playerStevanLukic);
            context.Players.Add(playerSteveCoates);
            context.Players.Add(playerBarryOHalloran);
            context.Players.Add(playerPaulBateman);
            context.Players.Add(playerVishalLadwa);
            context.Players.Add(playerBrendanClarke);
            context.Players.Add(playerDerekHartung);
            context.Players.Add(playerEmmaObichukwu);
            context.Players.Add(playerSimonWoods);
            context.Players.Add(playerHenryTruong);
            context.Players.Add(playerDevenPatel);
            context.Players.Add(playerSachinPatel);
            context.Players.Add(playerDavidFollant);
            context.Players.Add(playerPaulGoodson);
            context.Players.Add(playerPeterMajor);
            context.Players.Add(playerSumirKarayi);
            context.Players.Add(playerAldousAntony);
            context.Players.Add(playerSuKent);
            context.Players.Add(playerSeemaOommen);
            context.Players.Add(playerRajpalSingh);
            context.Players.Add(playerWernerVanderberg);
            context.Players.Add(playerRipalVaidya);
            context.Players.Add(playerNehaSood);
            context.Players.Add(playerRebeccaOni);
            context.Players.Add(playerPlayoffWinner);
            context.Players.Add(playerPlayoffLoser);
            context.Players.Add(playerLironSchur);
            context.Players.Add(playerVipulAsher);
            context.Players.Add(playerAdrianTodd);
            context.Players.Add(playerDimitraStavrinides);
            context.Players.Add(playerAndyBrand);
            context.Players.Add(playerMikeJefferson);
            context.Players.Add(playerShadrachAyidu);
            context.Players.Add(playerDaveHarding);
            context.Players.Add(playerAgnieszkaKelly);
            context.Players.Add(playerChrisBlayney);
            context.Players.Add(playerOliviaWatermeyer);
            context.Players.Add(playerAmarKaldate);
            context.Players.Add(playerBiswaDas);
            context.Players.Add(playerAndrewGoodman);
            context.Players.Add(playerRetoEgeter);
            context.Players.Add(playerScottMcGill);
            context.Players.Add(playerMattAlbert);
            context.Players.Add(playerEvinHill);
            context.Players.Add(playerMatthewLepselter);
            context.Players.Add(playerCarolineDuffy);
            context.Players.Add(playerEricBeller);
            context.Players.Add(playerDanHudson);
            context.Players.Add(playerOmarAbdeldayem);
            context.Players.Add(playerNoraPetrova);
            context.Players.Add(playerAshNanda);
            context.Players.Add(playerAnthonyCaw);
            context.Players.Add(playerNikhilKaluskar);

            var contents = new List<Contest>
            {
                new Contest { Id = Guid.NewGuid(), Name = "Game 1 - Shopping grudge match.", StartDate = new DateTime(2011, 3, 30), RoundLengthInDays = 2, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 5, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Game 2 - NightWatchman Server", StartDate = new DateTime(2011, 4, 11), RoundLengthInDays = 5, CreatedBy = playerChrisShallcross, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 5, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Game 3 - 1E Open League", StartDate = new DateTime(2011, 4, 14), RoundLengthInDays = 2, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 21, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "test", StartDate = new DateTime(2012, 2, 12), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 14, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Parallel League", StartDate = new DateTime(2011, 5, 25), RoundLengthInDays = 2, CreatedBy = playerBrendanClarke, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 11, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "support", StartDate = new DateTime(2011, 6, 6), RoundLengthInDays = 5, CreatedBy = playerHenryTruong, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 6, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Blue Square Support League", StartDate = new DateTime(2011, 6, 6), RoundLengthInDays = 3, CreatedBy = playerHenryTruong, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 10, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Tournament Beta", StartDate = new DateTime(2011, 6, 16), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 0, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Doubles", StartDate = new DateTime(2011, 7, 11), RoundLengthInDays = 5, CreatedBy = playerGokulRaju, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 6, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Doubles-tournament", StartDate = new DateTime(2011, 7, 11), RoundLengthInDays = 2, CreatedBy = playerGokulRaju, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 0, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Premiere League (Aug 2011)", StartDate = new DateTime(2011, 7, 18), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 3, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Championship (Aug 2011)", StartDate = new DateTime(2011, 7, 19), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Premiere League (Oct 2011)", StartDate = new DateTime(2011, 9, 5), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 5, ReligationSpots = 3, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Championship (Oct 2011)", StartDate = new DateTime(2011, 9, 6), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 4, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 1 (Oct 2011)", StartDate = new DateTime(2011, 9, 7), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 2 (Oct 2011)", StartDate = new DateTime(2011, 9, 5), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 7, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 2 (Dec 2011)", StartDate = new DateTime(2011, 10, 28), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 14, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Premiere League (Dec 2011)", StartDate = new DateTime(2011, 10, 25), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Championship (Dec 2011)", StartDate = new DateTime(2011, 10, 26), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 1 (Dec 2011)", StartDate = new DateTime(2011, 10, 27), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "The league of extraordinary gentlemen", StartDate = new DateTime(2011, 12, 19), RoundLengthInDays = 1, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 1, PlayingPoints = 1, NumberOfAllowedDefaultWins = 4, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "The league of extraordinary gentlemen II", StartDate = new DateTime(2012, 1, 3), RoundLengthInDays = 1, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 1, PlayingPoints = 1, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Premiere League (March 2012)", StartDate = new DateTime(2012, 1, 23), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2012, 3, 14), EndDate = new DateTime(2012, 3, 16) },
                new Contest { Id = Guid.NewGuid(), Name = "Championship (March 2012)", StartDate = new DateTime(2012, 1, 24), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 8, BestOutOf = 3, EndWarningDate = new DateTime(2012, 3, 12), EndDate = new DateTime(2012, 3, 16) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 1 (March 2012)", StartDate = new DateTime(2012, 1, 25), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2012, 3, 13), EndDate = new DateTime(2012, 3, 16) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 2", StartDate = new DateTime(2012, 1, 26), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = true, PromotionSpots = 1, PlayoffSpots = 2, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 7, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 2 (March 2012)", StartDate = new DateTime(2012, 1, 20), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 10, BestOutOf = 3, EndWarningDate = new DateTime(2012, 3, 15), EndDate = new DateTime(2012, 3, 16) },
                new Contest { Id = Guid.NewGuid(), Name = "The tournament of extraordinary gentlemen and phenomenal ladies", StartDate = new DateTime(2012, 2, 28), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 0, WinByDefaultPoints = 0, PlayingPoints = 0, NumberOfAllowedDefaultWins = 0, BestOutOf = 3, EndWarningDate = new DateTime(2012, 3, 15), EndDate = new DateTime(2012, 3, 15) },
                new Contest { Id = Guid.NewGuid(), Name = "The extraordinary league of Ping Pong Samurais", StartDate = new DateTime(2012, 3, 22), RoundLengthInDays = 3, CreatedBy = playerGokulRaju, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 3, WinByDefaultPoints = 1, PlayingPoints = 0, NumberOfAllowedDefaultWins = 5, BestOutOf = 3, EndWarningDate = new DateTime(2012, 5, 8), EndDate = new DateTime(2012, 5, 15) },
                new Contest { Id = Guid.NewGuid(), Name = "Test Out of 5", StartDate = new DateTime(2012, 3, 11), RoundLengthInDays = 2, CreatedBy = playerChrisShallcross, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 1, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 5, EndWarningDate = new DateTime(2012, 3, 19), EndDate = new DateTime(2012, 3, 19) },
                new Contest { Id = Guid.NewGuid(), Name = "Shopping Grudge II", StartDate = new DateTime(2012, 3, 14), RoundLengthInDays = 3, CreatedBy = playerSumantaSarkar, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 0, PlayingPoints = 0, NumberOfAllowedDefaultWins = 0, BestOutOf = 5, EndWarningDate = new DateTime(2012, 4, 10), EndDate = new DateTime(2012, 4, 14) },
                new Contest { Id = Guid.NewGuid(), Name = "Premiere League (May 2012)", StartDate = new DateTime(2012, 3, 23), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 1, PlayoffSpots = 0, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 5, EndWarningDate = new DateTime(2012, 5, 21), EndDate = new DateTime(2012, 5, 25) },
                new Contest { Id = Guid.NewGuid(), Name = "Championship (May 2012)", StartDate = new DateTime(2012, 3, 21), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 5, EndWarningDate = new DateTime(2012, 5, 21), EndDate = new DateTime(2012, 5, 25) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 1 (May 2012)", StartDate = new DateTime(2012, 3, 22), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 5, EndWarningDate = new DateTime(2012, 5, 21), EndDate = new DateTime(2012, 5, 25) },
                new Contest { Id = Guid.NewGuid(), Name = "Demo", StartDate = new DateTime(2012, 5, 7), RoundLengthInDays = 2, CreatedBy = playerChrisShallcross, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 1, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 3, EndWarningDate = new DateTime(2012, 5, 15), EndDate = new DateTime(2012, 5, 17) },
                new Contest { Id = Guid.NewGuid(), Name = "Demo 2", StartDate = new DateTime(2012, 5, 1), RoundLengthInDays = 2, CreatedBy = playerChrisShallcross, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 1, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 3, EndWarningDate = new DateTime(2012, 5, 28), EndDate = new DateTime(2012, 5, 30) },
                new Contest { Id = Guid.NewGuid(), Name = "Demo", StartDate = new DateTime(2012, 5, 22), RoundLengthInDays = 2, CreatedBy = playerAmarKaldate, Deleted = true, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 1, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 3, EndWarningDate = new DateTime(2012, 6, 15), EndDate = new DateTime(2012, 6, 19) },
                new Contest { Id = Guid.NewGuid(), Name = "Major League Ping Pong", StartDate = new DateTime(2012, 6, 18), RoundLengthInDays = 5, CreatedBy = playerAndrewGoodman, Deleted = false, PromotionSpots = 4, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 3, EndWarningDate = new DateTime(2012, 8, 20), EndDate = new DateTime(2012, 8, 24) },
                new Contest { Id = Guid.NewGuid(), Name = "Premiere League", StartDate = new DateTime(2012, 6, 12), RoundLengthInDays = 4, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 3, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 5, EndWarningDate = new DateTime(2012, 8, 15), EndDate = new DateTime(2012, 8, 22) },
                new Contest { Id = Guid.NewGuid(), Name = "Championship", StartDate = new DateTime(2012, 6, 13), RoundLengthInDays = 5, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 0, WinPoints = 2, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 5, EndWarningDate = new DateTime(2012, 8, 15), EndDate = new DateTime(2012, 8, 22) },
                new Contest { Id = Guid.NewGuid(), Name = "Division 1 (Aug 2011)", StartDate = new DateTime(2011, 7, 20), RoundLengthInDays = 3, CreatedBy = playerChrisShallcross, Deleted = false, PromotionSpots = 2, PlayoffSpots = 2, ReligationSpots = 0, WinPoints = 1, WinByDefaultPoints = 2, PlayingPoints = 0, NumberOfAllowedDefaultWins = 9, BestOutOf = 3, EndWarningDate = new DateTime(2011, 12, 31), EndDate = new DateTime(2011, 12, 31) },
                new Contest { Id = Guid.NewGuid(), Name = "First Floor Titans", StartDate = new DateTime(2012, 4, 15), RoundLengthInDays = 4, CreatedBy = playerAndrewBishop, Deleted = false, PromotionSpots = 0, PlayoffSpots = 0, ReligationSpots = 0, WinPoints = 3, WinByDefaultPoints = 2, PlayingPoints = 1, NumberOfAllowedDefaultWins = 3, BestOutOf = 3, EndWarningDate = new DateTime(2012, 5, 14), EndDate = new DateTime(2012, 5, 18) }
            };

            contents.ForEach(c => context.Contests.Add(c));
            
            base.Seed(context);
        }
    }
}

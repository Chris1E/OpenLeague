/*
This is a temporary file.
It contains the scripts needed to migrate the table tennis site data to the open league.
*/

-------------------------------------------------------------------------------------------
-- Player
INSERT INTO Players (Id, Name, Username)
		  SELECT NEWID(), 'Chris Shallcross', '1E\Chris.Shallcross'
	UNION SELECT NEWID(), 'Cosmin Onea', '1E\Cosmin.Onea'
	UNION SELECT NEWID(), 'Deepthi Daita', '1E\Deepthi.Daita'
	UNION SELECT NEWID(), 'Manish Kulkarni', '1E\Manish.Kulkarni'
	UNION SELECT NEWID(), 'Paul Aston', '1E\Paul.Aston'
	UNION SELECT NEWID(), 'Sumanta Sarkar', '1E\Sumanta.Sarkar'
	UNION SELECT NEWID(), 'Ed Sykes', '1E\Edward.Sykes'
	UNION SELECT NEWID(), 'Fred Kasadha', '1E\FredK'
	UNION SELECT NEWID(), 'Lax Hirani', '1E\Lax.Hirani'
	UNION SELECT NEWID(), 'Magdalena Mackow', '1E\Magdalena.Mackow'
	UNION SELECT NEWID(), 'Chintan Gupta', '1E\Chintan.Gupta'
	UNION SELECT NEWID(), 'Gokul Raju', '1E\Gokul.Raju'
	UNION SELECT NEWID(), 'Mark Jones', '1E\Mark.Jones'
	UNION SELECT NEWID(), 'Satoshi Nakane', '1E\Satoshi.Nakane'
	UNION SELECT NEWID(), 'Sushil Karwa', '1E\Sushil.Karwa'
	UNION SELECT NEWID(), 'Emilian Filip', '1E\Emilian.Filip'
	UNION SELECT NEWID(), 'Andrew Bishop', '1E\Andrew.Bishop'
	UNION SELECT NEWID(), 'Clement Unyereno', '1E\Clement.Unyereno'
	UNION SELECT NEWID(), 'Richard Cudd', '1E\RichardC'
	UNION SELECT NEWID(), 'Sophie Chang', '1E\sophiec'
	UNION SELECT NEWID(), 'Stevan Lukic', '1E\Stevan.Lukic'
	UNION SELECT NEWID(), 'Steve Coates', '1E\Steve.Coates'
	UNION SELECT NEWID(), 'Barry OHalloran', '1E\Barry.OHalloran'
	UNION SELECT NEWID(), 'Paul Bateman', '1E\Paul.Bateman'
	UNION SELECT NEWID(), 'Vishal Ladwa', '1E\Vishal.Ladwa'
	UNION SELECT NEWID(), 'Brendan Clarke', '1E\Brendan.Clarke'
	UNION SELECT NEWID(), 'Derek Hartung', '1E\Derekh'
	UNION SELECT NEWID(), 'Emma Obichukwu', '1E\Emma.Obichukwu'
	UNION SELECT NEWID(), 'Simon Woods', '1E\Simon.Woods'
	UNION SELECT NEWID(), 'Henry Truong', '1E\Henry.Truong'
	UNION SELECT NEWID(), 'Deven Patel', '1E\Deven.Patel'
	UNION SELECT NEWID(), 'Sachin Patel', '1E\Sachinp'
	UNION SELECT NEWID(), 'David Follant', '1E\dfollant'
	UNION SELECT NEWID(), 'Paul Goodson', '1E\PaulG'
	UNION SELECT NEWID(), 'Peter Major', '1E\Peter.Major'
	UNION SELECT NEWID(), 'Sumir Karayi', '1E\SumirK'
	UNION SELECT NEWID(), 'Aldous Antony', '1E\Aldous.Antony'
	UNION SELECT NEWID(), 'Su Kent', '1E\Su.Kent'
	UNION SELECT NEWID(), 'Seema Oommen', '1E\Seema.Oommen'
	UNION SELECT NEWID(), 'Rajpal Singh', '1E\RajpalS'
	UNION SELECT NEWID(), 'Werner Vanderberg', '1E\Werner.Vanderberg'
	UNION SELECT NEWID(), 'Ripal Vaidya', '1E\Ripal.Vaidya'
	UNION SELECT NEWID(), 'Neha Sood', '1E\Neha.Sood'
	UNION SELECT NEWID(), 'Rebecca Oni', '1E\Rebecca.Oni'
	UNION SELECT NEWID(), 'Playoff Winner', ''
	UNION SELECT NEWID(), 'Playoff Loser', ''
	UNION SELECT NEWID(), 'Liron Schur ', '1E\Liron.Schur'
	UNION SELECT NEWID(), 'Vipul Asher', '1E\Vipul.Asher'
	UNION SELECT NEWID(), 'Adrian Todd', '1E\Adrian.Todd'
	UNION SELECT NEWID(), 'Dimitra Stavrinides', '1E\Dimitra.Stavrinides'
	UNION SELECT NEWID(), 'Andy Brand', '1E\Andy.Brand'
	UNION SELECT NEWID(), 'Mike Jefferson', '1E\Mike.Jefferson'
	UNION SELECT NEWID(), 'Shadrach Ayidu', '1E\Shadrach.Ayidu'
	UNION SELECT NEWID(), 'Dave Harding', '1E\Dave.Harding'
	UNION SELECT NEWID(), 'Agnieszka Kelly', '1E\Agnieszka.Kelly'
	UNION SELECT NEWID(), 'Chris Blayney', '1E\Chris.Blayney'
	UNION SELECT NEWID(), 'Olivia Watermeyer', '1E\Olivia.Watermeyer'
	UNION SELECT NEWID(), 'Amar Kaldate', '1E\Amar.Kaldate'
	UNION SELECT NEWID(), 'Biswa Das', '1E\Biswa.Das'
	UNION SELECT NEWID(), 'Andrew Goodman', '1E\andrew.goodman'
	UNION SELECT NEWID(), 'Reto Egeter', '1E\Reto.Egeter'
	UNION SELECT NEWID(), 'Scott McGill', '1E\Scott.McGill'
	UNION SELECT NEWID(), 'Matt Albert', '1E\Matt.Albert'
	UNION SELECT NEWID(), 'Evin Hill', '1E\Evin.Hill'
	UNION SELECT NEWID(), 'Matthew Lepselter', '1E\Matthew.Lepselter'
	UNION SELECT NEWID(), 'Caroline Duffy', '1E\Caroline.Duffy'
	UNION SELECT NEWID(), 'Eric Beller', '1E\Eric.Beller'
	UNION SELECT NEWID(), 'Dan Hudson', '1E\Dan.Hudson'
	UNION SELECT NEWID(), 'Omar Abdeldayem', '1E\Omar.Abdeldayem'
	UNION SELECT NEWID(), 'Nora Petrova', '1E\Nora.Petrova'
	UNION SELECT NEWID(), 'Ash Nanda', '1E\Ash.Nanda'
	UNION SELECT NEWID(), 'Anthony Caw', '1E\Anthony.Caw'
	UNION SELECT NEWID(), 'Nikhil Kaluskar', '1E\Nikhil.Kaluskar'

/*
SELECT	'UNION SELECT NEWID(), ''' + Name + ''', ''' + UserName + ''''
FROM	Player
*/

-------------------------------------------------------------------------------------------
-- Contests
INSERT INTO Contests
(
	Id, Name, StartDate, RoundLengthInDays, CreatedBy_Id, Deleted, PromotionSpots,
	PlayoffSpots, ReligationSpots, WinPoints, WinByDefaultPoints, PlayingPoints,
	NumberOfAllowedDefaultWins, BestOutOf, CloseWarningDate, CloseDate, Discriminator
)
SELECT	C.Id, C.Name, C.StartDate, C.RoundLengthInDays, P.Id, C.Deleted, C.PromotionSpots,
		C.PlayoffSpots, C.ReligationSpots, C.WinPoints, C.WinByDefaultPoints, C.PlayingPoints,
		C.NumberOfAllowedDefaultWins, C.BestOutOf, C.CloseWarningDate, C.CloseDate, 'Contest'
FROM	Players P
			INNER JOIN
			(
				SELECT NEWID() Id, 'DONTUSETHISONE' Name, '' StartDate, 0 RoundLengthInDays, '' CreatedBy, 1 Deleted, 1 PromotionSpots, 1 PlayoffSpots, 1 ReligationSpots, 1 WinPoints, 1 WinByDefaultPoints, 1 PlayingPoints, 1 NumberOfAllowedDefaultWins, 1 BestOutOf, '' CloseWarningDate, '' CloseDate WHERE 1=0
				UNION SELECT NEWID(), 'Game 1 - Shopping grudge match.', '30 Mar 2011', 2, '1e\Chris.Shallcross', 0, 0, 0, 0, 1, 1, 0, 5, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Game 2 - NightWatchman Server', '11 Apr 2011', 5, '1e\Chris.Shallcross', 1, 0, 0, 0, 1, 1, 0, 5, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Game 3 - 1E Open League', '14 Apr 2011', 2, '1e\Chris.Shallcross', 0, 0, 0, 0, 1, 1, 0, 21, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'test', '12 Feb 2012', 3, '1E\Chris.Shallcross', 1, 0, 0, 0, 1, 1, 0, 14, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Parallel League', '25 May 2011', 2, '1E\Brendan.Clarke', 0, 0, 0, 0, 1, 1, 0, 11, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'support', '06 Jun 2011', 5, '1E\Henry.Truong', 1, 0, 0, 0, 1, 1, 0, 6, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Blue Square Support League', '06 Jun 2011', 3, '1E\Henry.Truong', 0, 0, 0, 0, 1, 1, 0, 10, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Tournament Beta', '16 Jun 2011', 3, '1E\Chris.Shallcross', 0, 0, 0, 0, 1, 1, 0, 0, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Doubles', '11 Jul 2011', 5, '1E\Gokul.Raju', 1, 0, 0, 0, 1, 1, 0, 6, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Doubles-tournament', '11 Jul 2011', 2, '1E\Gokul.Raju', 1, 0, 0, 0, 1, 1, 0, 0, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Premiere League (Aug 2011)', '18 Jul 2011', 3, '1E\Chris.Shallcross', 0, 1, 0, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Championship (Aug 2011)', '19 Jul 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Premiere League (Oct 2011)', '05 Sep 2011', 3, '1E\Chris.Shallcross', 0, 1, 5, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Championship (Oct 2011)', '06 Sep 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 4, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Division 1 (Oct 2011)', '07 Sep 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Division 2 (Oct 2011)', '05 Sep 2011', 4, '1E\Chris.Shallcross', 0, 2, 2, 0, 1, 1, 0, 7, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Division 2 (Dec 2011)', '28 Oct 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 0, 2, 2, 1, 14, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Premiere League (Dec 2011)', '25 Oct 2011', 4, '1E\Chris.Shallcross', 0, 1, 0, 3, 2, 2, 1, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Championship (Dec 2011)', '26 Oct 2011', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Division 1 (Dec 2011)', '27 Oct 2011', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'The league of extraordinary gentlemen', '19 Dec 2011', 1, '1E\Chris.Shallcross', 0, 1, 0, 0, 2, 1, 1, 4, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'The league of extraordinary gentlemen II', '03 Jan 2012', 1, '1E\Chris.Shallcross', 0, 1, 0, 0, 2, 1, 1, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Premiere League (March 2012)', '23 Jan 2012', 4, '1E\Chris.Shallcross', 0, 1, 0, 3, 2, 2, 1, 9, 3, '14 Mar 2012', '16 Mar 2012'
				UNION SELECT NEWID(), 'Championship (March 2012)', '24 Jan 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 8, 3, '12 Mar 2012', '16 Mar 2012'
				UNION SELECT NEWID(), 'Division 1 (March 2012)', '25 Jan 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 9, 3, '13 Mar 2012', '16 Mar 2012'
				UNION SELECT NEWID(), 'Division 2', '26 Jan 2012', 4, '1E\Chris.Shallcross', 1, 1, 2, 0, 2, 2, 1, 7, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'Division 2 (March 2012)', '20 Jan 2012', 4, '1E\Chris.Shallcross', 0, 2, 0, 0, 2, 2, 1, 10, 3, '15 Mar 2012', '16 Mar 2012'
				UNION SELECT NEWID(), 'The tournament of extraordinary gentlemen and phenomenal ladies', '28 Feb 2012', 4, '1E\Chris.Shallcross', 0, 0, 0, 0, 0, 0, 0, 0, 3, '15 Mar 2012', '15 Mar 2012'
				UNION SELECT NEWID(), 'The extraordinary league of Ping Pong Samurais', '22 Mar 2012', 3, '1E\Gokul.Raju', 0, 1, 0, 0, 3, 1, 0, 5, 3, '08 May 2012', '15 May 2012'
				UNION SELECT NEWID(), 'Test Out of 5', '11 Mar 2012', 2, '1E\Chris.Shallcross', 1, 0, 0, 0, 2, 1, 1, 3, 5, '19 Mar 2012', '19 Mar 2012'
				UNION SELECT NEWID(), 'Shopping Grudge II', '14 Mar 2012', 3, '1E\Sumanta.Sarkar', 1, 0, 0, 0, 2, 0, 0, 0, 5, '10 Apr 2012', '14 Apr 2012'
				UNION SELECT NEWID(), 'Premiere League (May 2012)', '23 Mar 2012', 3, '1E\Chris.Shallcross', 0, 1, 0, 3, 2, 2, 1, 3, 5, '21 May 2012', '25 May 2012'
				UNION SELECT NEWID(), 'Championship (May 2012)', '21 Mar 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 3, 5, '21 May 2012', '25 May 2012'
				UNION SELECT NEWID(), 'Division 1 (May 2012)', '22 Mar 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 0, 2, 2, 1, 3, 5, '21 May 2012', '25 May 2012'
				UNION SELECT NEWID(), 'Demo', '07 May 2012', 2, '1E\Chris.Shallcross', 1, 0, 0, 0, 2, 1, 1, 3, 3, '15 May 2012', '17 May 2012'
				UNION SELECT NEWID(), 'Demo 2', '01 May 2012', 2, '1E\Chris.Shallcross', 1, 0, 0, 0, 2, 1, 1, 3, 3, '28 May 2012', '30 May 2012'
				UNION SELECT NEWID(), 'Demo', '22 May 2012', 2, '1E\Amar.Kaldate', 1, 0, 0, 0, 2, 1, 1, 3, 3, '15 Jun 2012', '19 Jun 2012'
				UNION SELECT NEWID(), 'Major League Ping Pong', '18 Jun 2012', 5, '1E\andrew.goodman', 0, 4, 0, 0, 2, 1, 1, 3, 3, '20 Aug 2012', '24 Aug 2012'
				UNION SELECT NEWID(), 'Premiere League', '12 Jun 2012', 4, '1E\Chris.Shallcross', 0, 0, 0, 3, 2, 1, 1, 3, 5, '15 Aug 2012', '22 Aug 2012'
				UNION SELECT NEWID(), 'Championship', '13 Jun 2012', 5, '1E\Chris.Shallcross', 0, 2, 2, 0, 2, 1, 1, 3, 5, '15 Aug 2012', '22 Aug 2012'
				UNION SELECT NEWID(), 'Division 1 (Aug 2011)', '20 Jul 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 0, 1, 2, 0, 9, 3, '31 Dec 2011', '31 Dec 2011'
				UNION SELECT NEWID(), 'First Floor Titans', '15 Apr 2012', 4, '1E\Andrew.Bishop', 0, 0, 0, 0, 3, 2, 1, 3, 3, '14 May 2012', '18 May 2012'
			) C
			ON C.CreatedBy = P.UserName
ORDER BY C.StartDate



/*

SELECT 	'UNION SELECT NEWID(), ''' +
		GameName + ''', ''' + 
		CONVERT(VARCHAR(11), StartDate, 113) + ''', ' +
		LTRIM(PlayEveryXDays) + ', ''' + 
		CreatedBy + ''', ' + 
		LTRIM(Deleted) + ', ' + 
		LTRIM(PromotionSpots) + ', ' +
		LTRIM(PlayoffSpots) + ', ' + 
		LTRIM(ReligationSpots) + ', ' + 
		LTRIM(WinPoints) + ', ' + 
		LTRIM(WinByDefaultPoints) + ', ' +
		LTRIM(PlayingPoints) + ', ' +
		LTRIM(AllowedDefaultWins) + ', ' + 
		LTRIM(BestOutOf) + ', ''' +
		CONVERT(VARCHAR(11), CloseWarningDate, 113) + ''', ''' + 
		CONVERT(VARCHAR(11), ClosedDate, 113) + ''''
FROM	Game
*/



/*
This is a temporary file.
It contains the scripts needed to migrate the table tennis site data to the open league.
*/

INSERT INTO Contests
(
	Id, Name, StartDate, RoundLengthInDays, CreatedBy, Deleted, PromotionSpots,
	PlayoffSpots, ReligationSpots, WinPoints, WinByDefaultPoints, PlayingPoints,
	NumberOfAllowedDefaultWins, BestOutOf, CloseWarningDate, CloseDate, Discriminator
)
SELECT NEWID(), 'Game 1 - Shopping grudge match.', '30 Mar 2011', 2, '1e\Chris.Shallcross', 0, 0, 0, 0, 1, 1, 0, 5, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Game 2 - NightWatchman Server', '11 Apr 2011', 5, '1e\Chris.Shallcross', 1, 0, 0, 0, 1, 1, 0, 5, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Game 3 - 1E Open League', '14 Apr 2011', 2, '1e\Chris.Shallcross', 0, 0, 0, 0, 1, 1, 0, 21, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'test', '12 Feb 2012', 3, '1E\Chris.Shallcross', 1, 0, 0, 0, 1, 1, 0, 14, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Parallel League', '25 May 2011', 2, '1E\Brendan.Clarke', 0, 0, 0, 0, 1, 1, 0, 11, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'support', '06 Jun 2011', 5, '1E\Henry.Truong', 1, 0, 0, 0, 1, 1, 0, 6, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Blue Square Support League', '06 Jun 2011', 3, '1E\Henry.Truong', 0, 0, 0, 0, 1, 1, 0, 10, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Tournament Beta', '16 Jun 2011', 3, '1E\Chris.Shallcross', 0, 0, 0, 0, 1, 1, 0, 0, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Doubles', '11 Jul 2011', 5, '1E\Gokul.Raju', 1, 0, 0, 0, 1, 1, 0, 6, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Doubles-tournament', '11 Jul 2011', 2, '1E\Gokul.Raju', 1, 0, 0, 0, 1, 1, 0, 0, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Premiere League (Aug 2011)', '18 Jul 2011', 3, '1E\Chris.Shallcross', 0, 1, 0, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Championship (Aug 2011)', '19 Jul 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Premiere League (Oct 2011)', '05 Sep 2011', 3, '1E\Chris.Shallcross', 0, 1, 5, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Championship (Oct 2011)', '06 Sep 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 4, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Division 1 (Oct 2011)', '07 Sep 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 3, 1, 1, 0, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Division 2 (Oct 2011)', '05 Sep 2011', 4, '1E\Chris.Shallcross', 0, 2, 2, 0, 1, 1, 0, 7, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Division 2 (Dec 2011)', '28 Oct 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 0, 2, 2, 1, 14, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Premiere League (Dec 2011)', '25 Oct 2011', 4, '1E\Chris.Shallcross', 0, 1, 0, 3, 2, 2, 1, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Championship (Dec 2011)', '26 Oct 2011', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Division 1 (Dec 2011)', '27 Oct 2011', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'The league of extraordinary gentlemen', '19 Dec 2011', 1, '1E\Chris.Shallcross', 0, 1, 0, 0, 2, 1, 1, 4, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'The league of extraordinary gentlemen II', '03 Jan 2012', 1, '1E\Chris.Shallcross', 0, 1, 0, 0, 2, 1, 1, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Premiere League (March 2012)', '23 Jan 2012', 4, '1E\Chris.Shallcross', 0, 1, 0, 3, 2, 2, 1, 9, 3, '14 Mar 2012', '16 Mar 2012', 'contest'
UNION SELECT NEWID(), 'Championship (March 2012)', '24 Jan 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 8, 3, '12 Mar 2012', '16 Mar 2012', 'contest'
UNION SELECT NEWID(), 'Division 1 (March 2012)', '25 Jan 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 9, 3, '13 Mar 2012', '16 Mar 2012', 'contest'
UNION SELECT NEWID(), 'Division 2', '26 Jan 2012', 4, '1E\Chris.Shallcross', 1, 1, 2, 0, 2, 2, 1, 7, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'Division 2 (March 2012)', '20 Jan 2012', 4, '1E\Chris.Shallcross', 0, 2, 0, 0, 2, 2, 1, 10, 3, '15 Mar 2012', '16 Mar 2012', 'contest'
UNION SELECT NEWID(), 'The tournament of extraordinary gentlemen and phenomenal ladies', '28 Feb 2012', 4, '1E\Chris.Shallcross', 0, 0, 0, 0, 0, 0, 0, 0, 3, '15 Mar 2012', '15 Mar 2012', 'contest'
UNION SELECT NEWID(), 'The extraordinary league of Ping Pong Samurais', '22 Mar 2012', 3, '1E\Gokul.Raju', 0, 1, 0, 0, 3, 1, 0, 5, 3, '08 May 2012', '15 May 2012', 'contest'
UNION SELECT NEWID(), 'Test Out of 5', '11 Mar 2012', 2, '1E\Chris.Shallcross', 1, 0, 0, 0, 2, 1, 1, 3, 5, '19 Mar 2012', '19 Mar 2012', 'contest'
UNION SELECT NEWID(), 'Shopping Grudge II', '14 Mar 2012', 3, '1E\Sumanta.Sarkar', 1, 0, 0, 0, 2, 0, 0, 0, 5, '10 Apr 2012', '14 Apr 2012', 'contest'
UNION SELECT NEWID(), 'Premiere League (May 2012)', '23 Mar 2012', 3, '1E\Chris.Shallcross', 0, 1, 0, 3, 2, 2, 1, 3, 5, '21 May 2012', '25 May 2012', 'contest'
UNION SELECT NEWID(), 'Championship (May 2012)', '21 Mar 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 3, 2, 2, 1, 3, 5, '21 May 2012', '25 May 2012', 'contest'
UNION SELECT NEWID(), 'Division 1 (May 2012)', '22 Mar 2012', 4, '1E\Chris.Shallcross', 0, 2, 2, 0, 2, 2, 1, 3, 5, '21 May 2012', '25 May 2012', 'contest'
UNION SELECT NEWID(), 'Demo', '07 May 2012', 2, '1E\Chris.Shallcross', 1, 0, 0, 0, 2, 1, 1, 3, 3, '15 May 2012', '17 May 2012', 'contest'
UNION SELECT NEWID(), 'Demo 2', '01 May 2012', 2, '1E\Chris.Shallcross', 1, 0, 0, 0, 2, 1, 1, 3, 3, '28 May 2012', '30 May 2012', 'contest'
UNION SELECT NEWID(), 'Demo', '22 May 2012', 2, '1E\Amar.Kaldate', 1, 0, 0, 0, 2, 1, 1, 3, 3, '15 Jun 2012', '19 Jun 2012', 'contest'
UNION SELECT NEWID(), 'Major League Ping Pong', '18 Jun 2012', 5, '1E\andrew.goodman', 0, 4, 0, 0, 2, 1, 1, 3, 3, '20 Aug 2012', '24 Aug 2012', 'contest'
UNION SELECT NEWID(), 'Premiere League', '12 Jun 2012', 4, '1E\Chris.Shallcross', 0, 0, 0, 3, 2, 1, 1, 3, 5, '15 Aug 2012', '22 Aug 2012', 'contest'
UNION SELECT NEWID(), 'Championship', '13 Jun 2012', 5, '1E\Chris.Shallcross', 0, 2, 2, 0, 2, 1, 1, 3, 5, '15 Aug 2012', '22 Aug 2012', 'contest'
UNION SELECT NEWID(), 'Division 1 (Aug 2011)', '20 Jul 2011', 3, '1E\Chris.Shallcross', 0, 2, 2, 0, 1, 2, 0, 9, 3, '31 Dec 2011', '31 Dec 2011', 'contest'
UNION SELECT NEWID(), 'First Floor Titans', '15 Apr 2012', 4, '1E\Andrew.Bishop', 0, 0, 0, 0, 3, 2, 1, 3, 3, '14 May 2012', '18 May 2012', 'contest'

SELECT * FROM Contests


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
		CONVERT(VARCHAR(11), ClosedDate, 113) + ''', ''contest'''
FROM	Game
*/
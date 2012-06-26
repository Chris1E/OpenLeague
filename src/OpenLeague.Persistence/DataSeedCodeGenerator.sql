select 'var player' + Replace(Name, ' ', '') + ' = new Player { Id = Guid.NewGuid(), Name = "' + Name + '", Username = @"' + Username + '", PictureUrl = "http:/tbd/' +
Replace(Name, ' ', '') +
'.jpg" };'
from player


select 'context.Players.Add(player' + Replace(Name, ' ', '') + ');'
from player

SELECT 	'new Contest { Id = Guid.NewGuid(), Name = "' +
		GameName + '", StartDate = new DateTime(' + 
		LTRIM(YEAR(StartDate)) + ', ' +
		LTRIM(MONTH(StartDate)) + ', ' +
		LTRIM(DAY(StartDate)) +
		'), RoundLengthInDays = ' +
		LTRIM(PlayEveryXDays) + ', CreatedBy = player' + 
		Replace(Replace(CreatedBy, '.', ''), '1e\', '') + ', Deleted = ' + 
		CASE WHEN Deleted = 0 THEN 'false' ELSE 'true' END  + ', PromotionSpots = ' + 
		LTRIM(PromotionSpots) + ', PlayoffSpots = ' +
		LTRIM(PlayoffSpots) + ', ReligationSpots = ' + 
		LTRIM(ReligationSpots) + ', WinPoints = ' + 
		LTRIM(WinPoints) + ', WinByDefaultPoints = ' + 
		LTRIM(WinByDefaultPoints) + ', PlayingPoints = ' +
		LTRIM(PlayingPoints) + ', NumberOfAllowedDefaultWins = ' +
		LTRIM(AllowedDefaultWins) + ', BestOutOf = ' + 
		LTRIM(BestOutOf) + ', EndWarningDate = new DateTime(' + 
		LTRIM(YEAR(CloseWarningDate)) + ', ' +
		LTRIM(MONTH(CloseWarningDate)) + ', ' +
		LTRIM(DAY(CloseWarningDate)) + '), EndDate = new DateTime(' + 
		LTRIM(YEAR(ClosedDate)) + ', ' +
		LTRIM(MONTH(ClosedDate)) + ', ' +
		LTRIM(DAY(ClosedDate)) + ') },'
FROM	Game
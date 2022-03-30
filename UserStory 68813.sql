USE [cldbConnect]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [api].[vwRecBase]

as

Select x.*,

cur.fldId as CurrencyId,

lang.fldId as LanguageId

FROM
(
select Id,
RowGuid,
FileNo,
RecNumber,
RecMonth,
RecYear,
RecSubLetter,
RecCategoryId as ImpactId,
RecStatusId as StatusId,
StatusDate,
PrimaryRecTypeId,
SecondaryRecTypeId,
RecKeyWords,
ResponseDate as RespDate,
ResponseFrom as RespFrom,
IntendedActionId,
ExpectedCompletionDate,
PlantComment as FacilityComment,
MgmtRespDate,
MgmtRespFrom,
MgmtRespActionId,
MgmtRespComment,
ThirdLevelRespDate,
ThirdLevelRespFrom,
ThirdLevelRespActionId,
ThirdLevelRespComment,
CASE WHEN Hazard='Fire' THEN 1 ELSE 5 END RecTypeId,
3 as PracticeId,
LossExpectancyBefore as CurrentLossEstimateRange,
LossExpectancyBeforeActual as CurrentLossEstimate,
LossExpectancyAfter as CompletedLossEstimateRange,
LossExpectancyAfterActual as CompletedLossEstimate,
CostToComplete as CostToCompleteEstimateRange,
CostToCompleteActual as CostToCompleteEstimate,
ActualCostToComplete as CostToComplete,
SavingsRatio,
RecCode,
Hazard,
c.FilePrefix,
c.ExchangeRateGroupID as ClientExchangeRateGroupId,
RecDetail
FROM [Fire-Recommendations] x
INNER JOIN clients c ON c.FilePrefix = x.FilePrefix

UNION 

select Id,
RowGuid,
FileNo,
RecNumber,
RecMonth,
RecYear,
RecSubLetter,
RecCategoryId as ImpactId,
RecStatusId as StatusId,
StatusDate,
PrimaryRecTypeId,
SecondaryRecTypeId,
RecKeyWords,
ResponseDate as RespDate,
ResponseFrom as RespFrom,
IntendedActionId,
ExpectedCompletionDate,
PlantComment as FacilityComment,
MgmtRespDate,
MgmtRespFrom,
MgmtRespActionId,
MgmtRespComment,
ThirdLevelRespDate,
ThirdLevelRespFrom,
ThirdLevelRespActionId,
ThirdLevelRespComment,
2 as RecTypeId,
2 as PracticeId,
LossExpectancyBefore as CurrentLossEstimateRange,
LossExpectancyBeforeActual as CurrentLossEstimate,
LossExpectancyAfter as CompletedLossEstimateRange,
LossExpectancyAfterActual as CompletedLossEstimate,
CostToComplete as CostToCompleteEstimateRange,
CostToCompleteActual as CostToCompleteEstimate,
ActualCostToComplete as CostToComplete,
SavingsRatio,
RecCode,
'' as Hazard,
c.FilePrefix,
c.ExchangeRateGroupID as ClientExchangeRateGroupId,
RecDetail
FROM [bM-Recommendations] x
INNER JOIN clients c ON c.FilePrefix = x.FilePrefix

UNION 

select Id,
RowGuid,
FileNo,
RecNumber,
RecMonth,
RecYear,
RecSubLetter,
RecCategoryId as ImpactId,
RecStatusId as StatusId,
StatusDate,
PrimaryRecTypeId,
SecondaryRecTypeId,
RecKeyWords,
ResponseDate as RespDate,
ResponseFrom as RespFrom,
IntendedActionId,
ExpectedCompletionDate,
PlantComment as FacilityComment,
MgmtRespDate,
MgmtRespFrom,
MgmtRespActionId,
MgmtRespComment,
ThirdLevelRespDate,
ThirdLevelRespFrom,
ThirdLevelRespActionId,
ThirdLevelRespComment,
3 as RecTypeId,
11 as PracticeId,
LossExpectancyBefore as CurrentLossEstimateRange,
LossExpectancyBeforeActual as CurrentLossEstimate,
LossExpectancyAfter as CompletedLossEstimateRange,
LossExpectancyAfterActual as CompletedLossEstimate,
CostToComplete as CostToCompleteEstimateRange,
CostToCompleteActual as CostToCompleteEstimate,
ActualCostToComplete as CostToComplete,
SavingsRatio,
RecCode,
'' as Hazard,
c.FilePrefix,
c.ExchangeRateGroupID as ClientExchangeRateGroupId,
RecDetail
FROM [PsRecommendations]  x
INNER JOIN clients c ON c.FilePrefix = x.FilePrefix

UNION

select Id,
RowGuid,
FileNo,
RecNumber,
RecMonth,
RecYear,
'' as RecSubLetter,
RecCategoryId as ImpactId,
RecStatusId as StatusId,
StatusDate,
PrimaryRecTypeId,
SecondaryRecTypeId,
Recommendation as RecKeyWords,
ResponseDate as RespDate,
ResponseFrom as RespFrom,
IntendedActionId,
ExpectedCompletionDate,
PlantComment as FacilityComment,
MgmtRespDate,
MgmtRespFrom,
MgmtRespActionId,
MgmtRespComment,
ThirdLevelRespDate,
ThirdLevelRespFrom,
ThirdLevelRespActionId,
ThirdLevelRespComment,
4 as RecTypeId,
4 as PracticeId,
'00. Not Available' as CurrentLossEstimateRange,
0 as CurrentLossEstimate,
'00. Not Available' as CompletedLossEstimateRange,
0 as CompletedLossEstimate,
'00. Not Available' CostToCompleteEstimateRange,
0 as CostToCompleteEstimate,
0 as CostToComplete,
0 as SavingsRatio,
'' as RecCode,
'' as Hazard,
c.FilePrefix,
c.ExchangeRateGroupID as ClientExchangeRateGroupId,
null as RecDetails
FROM [Findings]  x
INNER JOIN clients c ON c.FilePrefix = x.FilePrefix

UNION

select Id,
RowGuid,
FileNo,
RecNumber,
RecMonth,
RecYear,
RecSubLetter,
RecCategoryId as ImpactId,
RecStatusId as StatusId,
StatusDate,
PrimaryRecTypeId,
SecondaryRecTypeId,
RecKeyWords,
ResponseDate as RespDate,
ResponseFrom as RespFrom,
IntendedActionId,
ExpectedCompletionDate,
PlantComment as FacilityComment,
MgmtRespDate,
MgmtRespFrom,
MgmtRespActionId,
MgmtRespComment,
ThirdLevelRespDate,
ThirdLevelRespFrom,
ThirdLevelRespActionId,
ThirdLevelRespComment,
6 as RecTypeId,
--setting PracticeId to 3 because currently only fire recs are self-audit recs.  Will need to revisit should other practices contain SA recs
3 as PracticeId ,
LossExpectancyBefore as CurrentLossEstimateRange,
LossExpectancyBeforeActual as CurrentLossEstimate,
LossExpectancyAfter as CompletedLossEstimateRange,
LossExpectancyAfterActual as CompletedLossEstimate,
CostToComplete as CostToCompleteEstimateRange,
CostToCompleteActual as CostToCompleteEstimate,
ActualCostToComplete as CostToComplete,
SavingsRatio,
RecCode,
'Fire self-audit' as Hazard,
c.FilePrefix,
c.ExchangeRateGroupID as ClientExchangeRateGroupId,
RecDetail

FROM [SelfAuditRecommendations] x
INNER JOIN clients c ON c.FilePrefix = x.FilePrefix

) X 
CROSS JOIN tblMetaCurrency cur
CROSS JOIN tblMetaLanguage lang

GO


ALTER VIEW [api].[vwRec]
AS
SELECT 
     x.[Id]
    ,x.[RowGuid]
    ,x.[FileNo]
    ,x.[RecNumber]
    ,x.[RecMonth]
    ,x.[RecYear]
    ,x.[RecSubLetter]
    ,x.[ImpactId]
    ,x.[StatusId]
    ,x.[StatusDate]
    ,x.[PrimaryRecTypeId]
    ,x.[SecondaryRecTypeId]
    ,x.[RecKeyWords]
    ,x.[RespDate]
    ,x.[RespFrom]
    ,x.[IntendedActionId]
    ,x.[ExpectedCompletionDate]
    ,x.[FacilityComment]
    ,x.[MgmtRespDate]
    ,x.[MgmtRespFrom]
    ,x.[MgmtRespActionId]
    ,x.[MgmtRespComment]
    ,x.[ThirdLevelRespDate]
    ,x.[ThirdLevelRespFrom]
    ,x.[ThirdLevelRespActionId]
    ,x.[ThirdLevelRespComment]
    ,x.[RecTypeId]
    ,x.[PracticeId]
    ,x.[SavingsRatio]
    ,x.[RecCode]
    ,x.[FilePrefix]
    ,x.[ClientExchangeRateGroupId]
    ,x.[CurrencyId]
    ,x.[LanguageId],
	x.[Hazard],

CASE WHEN StatusId IN (3,4,6) THEN CAST(1 as bit) ELSE CAST(0 as bit) END as IsAutoRec,

CASE WHEN StatusId IN (3,4,6) THEN CAST(1 as bit) ELSE CAST(0 as bit) END as IsOpen,

CAST(CASE WHEN StatusId IN (3,4,6) AND (COALESCE(RespDate,'1/1/1900') < StatusDate) THEN 1 ELSE 0 END as bit) as IsResponseNeeded,

CASE WHEN StatusId IN (3,4) AND (COALESCE(RespDate,'1/1/1900') < StatusDate) THEN '#FF0000' END AS ResponseDateBackColor,

ImpactBackColorHex = 
	CASE ImpactId
		WHEN 1 THEN '#FF0000'
		WHEN 2 THEN '#00FF00'
		WHEN 3 THEN '#FFFF00'
	END,

ExpectedCompletionDateBackColorHex = 
CASE 
		WHEN ISDATE(ExpectedCompletionDate)=1 
		THEN 
			CASE 
				WHEN ExpectedCompletionDate > GETDATE() AND ExpectedCompletionDate <= DATEADD(m,1,GETDATE()) THEN '#FFFF00'
				WHEN ExpectedCompletionDate < GETDATE() THEN '#FF0000'
			END	
END,

i.DisplayText as Impact,

a.DisplayText as IntendedAction, 

ma.DisplayText as MgmtRespAction, 

tla.DisplayText as ThirdLevelRespAction,

s.DisplayText as [Status], 

COALESCE(pt.PrimaryRecTypeDisplayText, pt.PrimaryRecType) as PrimaryRecType, 

COALESCE(pt.SecondaryRecTypeDisplayText, pt.SecondaryRecType) as SecondaryRecType,

dbo.fnConvertLossEstimateRangeNew (CurrentLossEstimateRange,ClientExchangeRateGroupId,1,CurrencyId)  as CurrentLossEstimateRange,

dbo.fnConvertLossEstimateRangeNew (CompletedLossEstimateRange,ClientExchangeRateGroupId,2,CurrencyId)  as CompletedLossEstimateRange,

dbo.fnConvertLossEstimateRangeNew (CostToCompleteEstimateRange,ClientExchangeRateGroupId,3,CurrencyId)  as CostToCompleteEstimateRange,

dbo.fnConvertCurrencyNew (CurrentLossEstimate,ClientExchangeRateGroupId,CurrencyId)  as CurrentLossEstimate,

dbo.fnConvertCurrencyNew (CompletedLossEstimate,ClientExchangeRateGroupId,CurrencyId)  as CompletedLossEstimate,

dbo.fnConvertCurrencyNew (CostToCompleteEstimate,ClientExchangeRateGroupId,CurrencyId)  as CostToCompleteEstimate,

dbo.fnConvertCurrencyNew (CostToComplete,ClientExchangeRateGroupId,CurrencyId)  as CostToComplete,
x.RecDetail

FROM api.vwRecBase x
INNER JOIN api.vwMetaRecImpact i ON x.ImpactId=i.Id AND x.LanguageId=i.LanguageId
INNER JOIN api.vwMetaRecAction a ON x.IntendedActionId=a.Id AND x.LanguageId=a.LanguageId
INNER JOIN api.vwMetaRecMgmtAction ma ON x.MgmtRespActionId=ma.Id AND x.LanguageId=ma.LanguageId
INNER JOIN api.vwMetaRecThirdLevelAction tla ON x.ThirdLevelRespActionId=tla.Id AND x.LanguageId=tla.LanguageId
INNER JOIN api.vwMetaRecTypePair pt ON 
	x.PrimaryRecTypeId=pt.PrimaryRecTypeId 
	AND x.SecondaryRecTypeId=pt.SecondaryRecTypeId 
	AND x.LanguageId=pt.LanguageId
	AND pt.PracticeId = (
		case 
			when RecTypeId=1 then 3 --fire
			when RecTypeId=2 then 2 --bm
			when RecTypeId=3 then 11 --proc safety
			when RecTypeId=4 then 4 --ir
			when RecTypeId=5 then 9 --nathax
			when RecTypeId=6 then 3  --self audit. (using 3 for Fire recs. Will need to revisit if other practices have SA recs)
		end
	)
INNER JOIN api.vwMetaRecStatus s ON x.StatusId=s.Id AND x.LanguageId=s.LanguageId


GO



SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE SCHEMA api2 ;  
GO

 

CREATE TABLE api2.Account(
	[ID]			[int] IDENTITY(1,1)	NOT NULL,
	FilePrefix		varchar(50)			NOT NULL,
	UserID			varchar(50)			NOT NULL,
	UserPassword	varbinary (8000)	NOT NULL,
	CurrencyID		int					NOT NULL,
	LastLogin		datetime			NULL,
	InvalidAttempts	int					NOT NULL DEFAULT(0)
CONSTRAINT [PK_API_Account] PRIMARY KEY CLUSTERED ([ID])
)

go


CREATE TABLE api2.LogTable(
	[ID]			[int] IDENTITY(1,1)	NOT NULL,
	UserID			varchar(50)			NOT NULL,
	Activity		varchar(8000)		NOT NULL,
	ActivityDate	smalldatetime		NULL
CONSTRAINT [PK_API_LogTable] PRIMARY KEY CLUSTERED ([ID])
)

go


--drop FUNCTION dbo.fnGeneratePassword 
go

CREATE FUNCTION dbo.fnGeneratePassword (
	@UserPassword	varchar(50)
)
RETURNS varbinary(8000)

AS
/*
Created Feb 2022 by M Rauch 
This will return a non-cleartext password given a cleartext password
print dbo.fnGeneratePassword('passwordstring')
*/

BEGIN
	DECLARE 
		@Hash NVARCHAR(32),
		@pwd varbinary (8000)

	SET @Hash = CONVERT(NVARCHAR(32), @UserPassword)
	set @pwd =  HASHBYTES('SHA2_256', @Hash)
	
	RETURN @pwd
END
GO


--drop FUNCTION dbo.fnPasswordIsValid
go

CREATE FUNCTION dbo.fnPasswordIsValid (
	@ClearTextPassword		varchar(50),
	@NonClearTextPassword	varbinary(8000)
)
RETURNS bit

AS
/*
Created Feb 2022 by M Rauch 
This will determine whether or not the passwords are the same
print dbo.fnPasswordIsValid ('test','thisismypassword')
*/

BEGIN
	DECLARE @IsValid bit

	if @NonClearTextPassword = dbo.fnGeneratePassword(@ClearTextPassword)
		set @IsValid  = 1
	else
		set @IsValid  = 0

	return @IsValid

END
GO



--DROP PROCEDURE api2.spAuthenticate 
GO

CREATE PROCEDURE api2.spAuthenticate (
	@UserID			varchar(50),
	@UserPassword	varchar(50),
	@Valid			bit				OUTPUT,
	@FilePrefix		varchar(50)		OUTPUT,
	@ErrorNumber	int				OUTPUT,
	@ErrorMessage	varchar(max)	OUTPUT
)
AS

/*
declare @v bit, @client varchar(8), @err int, @emsg varchar(max)
exec api2.spAuthenticate 'test', 'testpw', @v output, @client output, @err output, @emsg output
select @v , @client , @err , @emsg 
*/

SET NOCOUNT ON

BEGIN TRY

	declare 
		@NonClearTextPassword	varbinary(8000),
		@numInvalidAttempts		int

	set @Valid = 0

	select @FilePrefix = FilePrefix, @NonClearTextPassword = UserPassword, @numInvalidAttempts = InvalidAttempts
	  from api2.Account 
	 where UserID = @UserID

	if @FilePrefix is null
		BEGIN
			set @ErrorNumber = 500
			set @ErrorMessage = 'Invalid credentials'
		END
	else
		if @numInvalidAttempts >= 3
			BEGIN
				update api2.Account set InvalidAttempts = InvalidAttempts + 1 where UserID = @UserID 
				set @ErrorNumber = 501
				set @ErrorMessage = 'Account is locked due to too many incorrect password attempts'
			END
		else
			BEGIN
				if dbo.fnPasswordIsValid (@UserPassword, @NonClearTextPassword) = 0
					BEGIN
						update api2.Account set InvalidAttempts = InvalidAttempts + 1 where UserID = @UserID 
						set @ErrorNumber = 500
						set @ErrorMessage = 'Invalid credentials'
					END
				else
					BEGIN
						set @ErrorNumber = 0
						set @ErrorMessage = ''
						set @Valid = 1
						update api2.Account set LastLogin = getdate(), InvalidAttempts = 0 where @UserID = @UserID 
					END
			END

	if @ErrorNumber = 0
		insert into api2.LogTable values (@UserID, 'Authentication succeeded', getdate())
	else
		insert into api2.LogTable values (@UserID, 'Authentication failed - ' + @ErrorMessage, getdate())

END TRY  
BEGIN CATCH  
    
	set @FilePrefix = null
	set @Valid = 0
	set @ErrorNumber = ERROR_NUMBER()
	set @ErrorMessage = ERROR_MESSAGE() 

END CATCH;  
go


--drop PROCEDURE api2.spGetRecommendations 
go
create PROCEDURE api2.spGetRecommendations (
	@FilePrefix		varchar(50),
	@JSON			varchar(max)	OUTPUT,
	@ErrorNumber	int				OUTPUT,
	@ErrorMessage	varchar(max)	OUTPUT
)
AS

/*
declare @err int, @emsg varchar(max), @j varchar(max)
exec api2.spGetRecommendations '1001', @j output,@err output, @emsg output
select @err , @emsg , @j
*/

SET NOCOUNT ON

BEGIN TRY

	declare
		@clientfeatures	varchar(255),
		@currency		varchar(3),
		@currencyID		int,
		@sql			nvarchar(max)

	set @ErrorNumber = 0
	set @ErrorMessage = ''
	
	select @clientfeatures = features from dbo.clients where FilePrefix = @FilePrefix 
	select @currencyID = CurrencyID from api2.Account where FilePrefix = @FilePrefix 
	select @currency = fldCode from dbo.tblMetaCurrency where fldid = @currencyID 

	SELECT fldRecommendationID, count(*) as NumDocuments
	  into #RecDocCount
	  FROM dbo.tblUploadFileRec
	 group by fldRecommendationID

	select	r.fileNo, r.RowGuid as recGUID, r.Hazard as [service],
			r.recYear, r.recMonth, r.recNumber, r.recSubletter, r.[status],
			ISNULL(c.NumDocuments,0) as numberOfDocuments,
			@currency as currency,
			CASE r.Hazard WHEN 'Fire-SA' THEN 'Client' else 'GRC' END as inspectionPerformedBy,
			CAST(r.statusDate as DATE) as statusDate,
			r.impact,
			r.primaryRecType as primaryType,
			r.SecondaryRecType as secondaryType,
			r.RecKeyWords as keywords,
			r.RecDetail as [description],
			CAST(r.CurrentLossEstimate as DECIMAL(10,1)) as currentLossEstimate,
			r.CurrentLossEstimateRange as currentLossEstimateRange,
			CAST(r.CompletedLossEstimate as DECIMAL(10,1)) as completedLossEstimate,
			r.CompletedLossEstimateRange as completedLossEstimateRange,
			CAST(r.CostToCompleteEstimate as DECIMAL(10,1)) as costToCompleteEstimate,
			r.CostToCompleteEstimateRange as costToCompleteEstimateRange,
			r.CostToComplete as costToCompleteActual,
			r.SavingsRatio as savingsRatio,
			r.IntendedAction as intendedAction,
			CAST(r.RespDate as DATE) as responseDate,
			r.RespFrom as responseFrom,
			r.FacilityComment as facilityComment,
			CAST(r.ExpectedCompletionDate as DATE) as expectedCompletionDate,
			r.MgmtRespAction as mgmtResponseAction,
			CAST(r.MgmtRespDate as DATE) as mgmtResponseDate,
			r.MgmtRespFrom as mgmtResponseFrom,
			r.MgmtRespComment as mgmtResponseComment,
			r.ThirdLevelRespAction as thirdLevelResponseAction,
			CAST(r.ThirdLevelRespDate as DATE) as thirdLevelResponseDate,
			r.ThirdLevelRespFrom as thirdLevelResponseFrom,
			r.ThirdLevelRespComment as thirdLevelResponseComment,
			r.RecCode as recCode
	  into #recs
	  from api.vwRec				r
			left outer join	#RecDocCount c on r.Id = c.fldRecommendationID 
	 where FilePrefix = @FilePrefix 
	   and LanguageId = 1
	   and CurrencyId = @currencyID

	set @sql = 'select fileNo, recGUID, [service], recYear, recMonth, recNumber, recSubletter, [status], numberOfDocuments, currency,'
	set @sql = @sql + ' inspectionPerformedBy, statusDate, impact, primaryType, secondaryType, keywords, currentLossEstimate,'
	set @sql = @sql + ' currentLossEstimateRange, completedLossEstimate, completedLossEstimateRange, costToCompleteEstimate, costToCompleteEstimateRange,'
	set @sql = @sql + ' costToCompleteActual, savingsRatio, intendedAction, responseDate, responseFrom, facilityComment, expectedCompletionDate'

	if CHARINDEX(@clientfeatures, '+') > 0			-- this client uses management responses
		set @sql = @sql + ',  mgmtResponseAction, mgmtResponseDate, mgmtResponseFrom, mgmtResponseComment'

	if CHARINDEX(@clientfeatures, '@') > 0			-- this client uses third level responses
		set @sql = @sql + ',  thirdLevelResponseAction, thirdLevelResponseDate, thirdLevelResponseFrom, thirdLevelResponseComment'

	if CHARINDEX(@clientfeatures, 'X') > 0				-- this client uses the REC CODE feature
		set @sql = @sql + ',  recCode'

	set @sql = @sql + ' from #recs for JSON AUTO , INCLUDE_NULL_VALUES'

	exec sp_executesql @sql

set @JSON = (
select fileNo, recGUID, [service], recYear, recMonth, recNumber, recSubletter, [status], numberOfDocuments, currency,
inspectionPerformedBy, statusDate, impact, primaryType, secondaryType, keywords, currentLossEstimate,
currentLossEstimateRange, completedLossEstimate, completedLossEstimateRange, costToCompleteEstimate, costToCompleteEstimateRange,
costToCompleteActual, savingsRatio, intendedAction, responseDate, responseFrom, facilityComment, expectedCompletionDate
from #recs for JSON AUTO , INCLUDE_NULL_VALUES
)

	insert into api2.LogTable values (@FilePrefix, 'GetRecommendations succeeded', getdate())

END TRY  
BEGIN CATCH  
    
	set @ErrorNumber = ERROR_NUMBER()
	set @ErrorMessage = ERROR_MESSAGE() 
	insert into api2.LogTable values (@FilePrefix, 'GetRecommendations failed', getdate())

END CATCH;  

DROP TABLE IF EXISTS #recs
DROP TABLE IF EXISTS #RecDocCount 

go


--drop PROCEDURE api2.spPutRecommendations 
go

CREATE PROCEDURE [api2].[spPutRecommendations] (
	@FilePrefix		varchar(50),
	@JSONstring		nvarchar(max),
	@ErrorNumber	int				OUTPUT,
	@ErrorMessage	varchar(max)	OUTPUT
)
AS

/*
*/

SET NOCOUNT ON

BEGIN TRY

	declare
		@numRows		int,
		@clientfeatures	varchar(255)

	set @ErrorNumber = 0
	set @ErrorMessage = ''

	SELECT * 
	  into #temp
	  FROM OPENJSON (@JSONstring)
	  WITH (   
		recGUID						uniqueidentifier '$.recGUID',
		responseDate				date			'$.responseDate',  
		responseFrom				nvarchar(75)	'$.responseFrom',
		facilityComment				varchar(8000)	'$.facilityComment',
		intendedAction				varchar(255)	'$.intendedAction',
		expectedCompletionDate		date			'$.expectedCompletionDate',  
		costToCompleteActual		int				'$.costToCompleteActual',
		mgmtResponseDate			date			'$.mgmtResponseDate',  
		mgmtResponseFrom			varchar(75)		'$.mgmtResponseFrom',
		mgmtResponseComment			varchar(8000)	'$.mgmtResponseComment',
		mgmtResponseAction			varchar(75)		'$.mgmtResponseAction',
		thirdLevelResponseDate		date			'$.thirdLevelResponseDate',  
		thirdLevelResponseFrom		varchar(75)		'$.thirdLevelResponseFrom',
		thirdLevelResponseComment	varchar(8000)	'$.thirdLevelResponseComment',
		thirdLevelResponseAction	varchar(75)		'$.thirdLevelResponseAction'   
	) 

	set @numRows = @@ROWCOUNT

	alter table #temp add
		intendedActionID			int,
		mgmtResponseActionID		int,
		thirdLevelResponseActionID	int,
		RecStatusID					int,
		RecStatus					varchar(50)

	-- Make sure they are not changing anyone else's data
	if (select count(*)
	      from #temp						t
				inner join api.vwRecBase	r on r.RowGuid = t.recGUID
		 where r.FilePrefix <> @FilePrefix
		) > 0
	  BEGIN
	  	set @ErrorNumber = 511
		set @ErrorMessage = 'Invalid recGUID(s) in data - security error.  No updates have been performed.'
		goto the_end
	  END

	-- Make sure all recGUIDs are valid
	if (select count(distinct r.RowGuid)
	      from #temp						t
				inner join api.vwRecBase	r on r.RowGuid = t.recGUID
		) <> @numRows 
	  BEGIN
	  	set @ErrorNumber = 512
		set @ErrorMessage = 'Invalid recGUID(s) in data.  No updates have been performed.'
		goto the_end
	  END

	-- Make sure all Intended Actions are valid
	update T
	   set intendedActionID = m.fldID
	  from #temp T inner join dbo.tblMetaRecIntendedAction m on ISNULL(T.IntendedAction,'') = ISNULL(m.fldAction,'')

	if exists (select 1 from #temp where IntendedActionID is null)
	  BEGIN
	  	set @ErrorNumber = 513
		set @ErrorMessage = 'Invalid intended action(s) in data.  No updates have been performed.'
		goto the_end
	  END

	-- Make sure all Mgmt Response Actions are valid
	update T
	   set mgmtResponseActionID = m.fldID
	  from #temp T inner join dbo.tblMetaRecMgmtIntendedAction m on isnull(T.mgmtResponseAction,'') = isnull(m.fldAction,'') 
	 where (@FilePrefix in (select fldPrefix from dbo.tblMetaRecMgmtIntendedAction) and m.fldPrefix in (-1,@FilePrefix))
	    or (@FilePrefix not in (select fldPrefix from dbo.tblMetaRecMgmtIntendedAction) and m.fldPrefix in (-1,0))


	if exists (select 1 from #temp where mgmtResponseAction is not null and mgmtResponseActionID is null)
	  BEGIN
	  	set @ErrorNumber = 514
		set @ErrorMessage = 'Invalid management action(s) in data.  No updates have been performed.'
		goto the_end
	  END

	-- Make sure all 3rd level Response Actions are valid
	update T
	   set thirdLevelResponseActionID = m.fldID
	  from #temp T inner join dbo.tblMetaRecThirdLevelIntendedAction m on isnull(T.thirdLevelResponseAction,'') = isnull(m.fldAction,'')
	 where (@FilePrefix in (select fldPrefix from dbo.tblMetaRecThirdLevelIntendedAction) and m.fldPrefix in (-1,@FilePrefix))
	    or (@FilePrefix not in (select fldPrefix from dbo.tblMetaRecThirdLevelIntendedAction) and m.fldPrefix in (-1,0))

	if exists (select 1 from #temp where thirdLevelResponseAction is not null and thirdLevelResponseActionID is null)
	  BEGIN
	  	set @ErrorNumber = 515
		set @ErrorMessage = 'Invalid third level action(s) in data.  No updates have been performed.'
		goto the_end
	  END

	-- Make sure required fields are populated
	select @clientfeatures = features from dbo.clients where FilePrefix = @FilePrefix 
	
	if CHARINDEX(@clientfeatures, 'R') > 0
		if exists (
				  select 1
				    from #temp
				   where IntendedAction not in ('Completed','Disagree - Will not complete','No Commitment')
					 and expectedCompletionDate is null
				)
			  BEGIN
	  			set @ErrorNumber = 516
				set @ErrorMessage = 'An expectedCompletionDate is required for the intended action(s) provided.  No updates have been performed.'
				goto the_end
			  END

	-- Set the RecStatus and RecStatusID in the #temp table depending on the IntendedAction
	UPDATE #temp
	   set RecStatus = CASE IntendedAction WHEN 'Completed' THEN 'Rptd Completed' WHEN 'In Progress' THEN 'In Progress' ELSE 'Outstanding' END

	update T
	   set RecStatusID = m.fldID
	  from #temp T inner join dbo.tblMetaRecStatus m on T.RecStatus = m.fldStatus

--select * from #temp
--select * from dbo.[bm-recommendations] where rowguid in (select recguid from #temp)

---- Update all the rec tables
	update r
	   set  RecStatus				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatus else t.RecStatus END,
			RecStatusID				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatusID else t.RecStatusID END,
			responseDate			= t.responseDate,
			responseFrom			= t.responseFrom,
			PlantComment			= t.facilityComment,
			intendedAction			= t.intendedAction,
			expectedCompletionDate	= t.expectedCompletionDate,  
			costToCompleteActual	= t.costToCompleteActual,
			mgmtRespDate			= t.mgmtResponseDate,
			mgmtRespFrom			= t.mgmtResponseFrom,
			mgmtRespComment			= t.mgmtResponseComment,
			mgmtRespAction			= t.mgmtResponseAction,
			thirdLevelRespDate		= t.thirdLevelResponseDate,
			thirdLevelRespFrom		= t.thirdLevelResponseFrom,
			thirdLevelRespComment	= t.thirdLevelResponseComment,
			thirdLevelRespAction	= t.thirdLevelResponseAction,
			IntendedActionId		= t.intendedActionID,
			MgmtRespActionId		= t.mgmtResponseActionID,
			ThirdLevelRespActionID	= t.thirdLevelResponseActionID,
			UpdateBy				= 'API'
	  from dbo.[fire-recommendations]	r
			inner join #temp			t on r.RowGuid = t.recGUID

	update r
	   set  RecStatus				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatus else t.RecStatus END,
			RecStatusID				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatusID else t.RecStatusID END,
			responseDate			= t.responseDate,
			responseFrom			= t.responseFrom,
			PlantComment			= t.facilityComment,
			intendedAction			= t.intendedAction,
			expectedCompletionDate	= t.expectedCompletionDate,  
			costToCompleteActual	= t.costToCompleteActual,
			mgmtRespDate			= t.mgmtResponseDate,
			mgmtRespFrom			= t.mgmtResponseFrom,
			mgmtRespComment			= t.mgmtResponseComment,
			mgmtRespAction			= t.mgmtResponseAction,
			thirdLevelRespDate		= t.thirdLevelResponseDate,
			thirdLevelRespFrom		= t.thirdLevelResponseFrom,
			thirdLevelRespComment	= t.thirdLevelResponseComment,
			thirdLevelRespAction	= t.thirdLevelResponseAction,
			IntendedActionId		= t.intendedActionID,
			MgmtRespActionId		= t.mgmtResponseActionID,
			ThirdLevelRespActionID	= t.thirdLevelResponseActionID,
			UpdateBy				= 'API'
	  from dbo.[bm-recommendations]	r
			inner join #temp			t on r.RowGuid = t.recGUID

	update r
	   set  RecStatus				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatus else t.RecStatus END,
			RecStatusID				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatusID else t.RecStatusID END,
			responseDate			= t.responseDate,
			responseFrom			= t.responseFrom,
			PlantComment			= t.facilityComment,
			intendedAction			= t.intendedAction,
			expectedCompletionDate	= t.expectedCompletionDate,  
			costToCompleteActual	= t.costToCompleteActual,
			mgmtRespDate			= t.mgmtResponseDate,
			mgmtRespFrom			= t.mgmtResponseFrom,
			mgmtRespComment			= t.mgmtResponseComment,
			mgmtRespAction			= t.mgmtResponseAction,
			thirdLevelRespDate		= t.thirdLevelResponseDate,
			thirdLevelRespFrom		= t.thirdLevelResponseFrom,
			thirdLevelRespComment	= t.thirdLevelResponseComment,
			thirdLevelRespAction	= t.thirdLevelResponseAction,
			IntendedActionId		= t.intendedActionID,
			MgmtRespActionId		= t.mgmtResponseActionID,
			ThirdLevelRespActionID	= t.thirdLevelResponseActionID,
			UpdateBy				= 'API'
	  from dbo.[PSrecommendations]	r
			inner join #temp			t on r.RowGuid = t.recGUID

	update r
	   set  RecStatus				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatus else t.RecStatus END,
			RecStatusID				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatusID else t.RecStatusID END,
			responseDate			= t.responseDate,
			responseFrom			= t.responseFrom,
			PlantComment			= t.facilityComment,
			intendedAction			= t.intendedAction,
			expectedCompletionDate	= t.expectedCompletionDate,  
			--costToCompleteActual	= t.costToCompleteActual,
			mgmtRespDate			= t.mgmtResponseDate,
			mgmtRespFrom			= t.mgmtResponseFrom,
			mgmtRespComment			= t.mgmtResponseComment,
			mgmtRespAction			= t.mgmtResponseAction,
			thirdLevelRespDate		= t.thirdLevelResponseDate,
			thirdLevelRespFrom		= t.thirdLevelResponseFrom,
			thirdLevelRespComment	= t.thirdLevelResponseComment,
			thirdLevelRespAction	= t.thirdLevelResponseAction,
			IntendedActionId		= t.intendedActionID,
			MgmtRespActionId		= t.mgmtResponseActionID,
			ThirdLevelRespActionID	= t.thirdLevelResponseActionID,
			UpdateBy				= 'API'
	  from dbo.Findings	r
			inner join #temp			t on r.RowGuid = t.recGUID

	update r
	   set  RecStatus				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatus else t.RecStatus END,
			RecStatusID				= CASE WHEN r.RecStatus in ('Advisory', 'Conf Completed', 'Removed') THEN r.RecStatusID else t.RecStatusID END,
			responseDate			= t.responseDate,
			responseFrom			= t.responseFrom,
			PlantComment			= t.facilityComment,
			intendedAction			= t.intendedAction,
			expectedCompletionDate	= t.expectedCompletionDate,  
			costToCompleteActual	= t.costToCompleteActual,
			mgmtRespDate			= t.mgmtResponseDate,
			mgmtRespFrom			= t.mgmtResponseFrom,
			mgmtRespComment			= t.mgmtResponseComment,
			mgmtRespAction			= t.mgmtResponseAction,
			thirdLevelRespDate		= t.thirdLevelResponseDate,
			thirdLevelRespFrom		= t.thirdLevelResponseFrom,
			thirdLevelRespComment	= t.thirdLevelResponseComment,
			thirdLevelRespAction	= t.thirdLevelResponseAction,
			IntendedActionId		= t.intendedActionID,
			MgmtRespActionId		= t.mgmtResponseActionID,
			ThirdLevelRespActionID	= t.thirdLevelResponseActionID,
			UpdateBy				= 'API'
	  from dbo.SelfAuditRecommendations r
			inner join #temp			t on r.RowGuid = t.recGUID

	the_end:

	if @ErrorNumber = 0
		insert into api2.LogTable values (@FilePrefix, 'PutRecommendations succeeded', getdate())
	else
		insert into api2.LogTable values (@FilePrefix, 'PutRecommendations failed - ' + @ErrorMessage, getdate())
--select * from #temp
--select * from dbo.[bm-recommendations] where rowguid in (select recguid from #temp)

END TRY  
BEGIN CATCH  
    
	set @ErrorNumber = ERROR_NUMBER()
	set @ErrorMessage = ERROR_MESSAGE() 
	insert into api2.LogTable values (@FilePrefix, 'PutRecommendations failed - ' + @ErrorMessage, getdate())

END CATCH;  


GO


--drop PROCEDURE api2.spGetRecommendationDocuments 
go

CREATE PROCEDURE [api2].[spGetRecommendationDocuments] (
	@FilePrefix		varchar(50),
	@RecGUID		uniqueidentifier,
	@JSON			varchar(max)	OUTPUT,
	@ErrorNumber	int				OUTPUT,
	@ErrorMessage	varchar(max)	OUTPUT
)
AS

/*
declare @err int, @emsg varchar(max), @j varchar(max)
exec api2.spGetRecommendationDocuments '1001', 'A658F91F-6132-4E2A-B8FA-F7C275EEF749', @j output, @err output, @emsg output
select @j, @err , @emsg 
*/

SET NOCOUNT ON

BEGIN TRY

	set @ErrorNumber = 0
	set @ErrorMessage = ''

	select DISTINCT Id 
	  into #recs
	  from api.vwRec 
	 where RowGuid = '058E066B-6C43-4DAB-82F5-576ABDEDFB1F' 
	   and FilePrefix = '1001'
	
	if @@ROWCOUNT = 0
	  BEGIN
	  	set @ErrorNumber = 521
		set @ErrorMessage = 'Invalid recGUID.'
		goto the_end
	  END

	SELECT DISTINCT 
		fldGuid as fileGUID,
		fldName as [fileName],
		fldContentType as fileType,
		fldByteLen as fileLength,
		fldExtension as fileExtension
	  INTO #temp
	  FROM dbo.tblUploadFile				f
		inner join dbo.tblUploadFileRec		fr on fr.fldUploadFileID = f.fldID 
		inner join #recs					r on fr.fldRecommendationID = r.Id 

	set @JSON = (
		SELECT *
		  FROM #temp
		  FOR JSON AUTO
	)

	SELECT * from #temp FOR JSON AUTO

	the_end:

	if @ErrorNumber = 0
		insert into api2.LogTable values (@FilePrefix, 'GetRecommendationDocuments succeeded', getdate())
	else
		insert into api2.LogTable values (@FilePrefix, 'GetRecommendationDocuments failed - ' + @ErrorMessage, getdate())

END TRY  
BEGIN CATCH  
    
	set @ErrorNumber = ERROR_NUMBER()
	set @ErrorMessage = ERROR_MESSAGE() 
	insert into api2.LogTable values (@FilePrefix, 'GetRecommendationDocuments failed - ' + @ErrorMessage, getdate())

END CATCH;  

DROP TABLE IF EXISTS #recs
DROP TABLE IF EXISTS #temp

go



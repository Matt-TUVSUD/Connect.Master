// AN ENUM FOR PAGE TYPES
// 0 = NONE, 1 = USER RECLASS, 2 = USER ACCOUNT
var dsUserFormType = {
    "none": 0,
    "UserAccount": 1,
    "UserReclassification": 2
};

// AN ENUM FOR ACTION CODES
// 0 = NONE, 1 = CONFIRM USER RECORD, 2 = INACTIVATE USER, 3 = DELETE USER RECORD
// NEED TO MATCH SERVER SIDE ENUM
// USE: dsUserReclassActions.userConfirm EQUALS 1
var dsUserReclassActions = {
    "none": "0",
    "userConfirm": "1",
    "userActivate": "2",
    "userInactivate": "3",
    "userDelete": "4"
};

// AN ENUM FOR RECORD NAVIGATION CODES
// NEED TO MATCH SERVER SIDE ENUM
// USE: dsUserNavActions.navFirst EQUALS 1
var dsUserNavActions = {
    "none": "0",
    "navFirst": "1",
    "navNext": "2",
    "navPrevious": "3",
    "navLast": "4"
};

var dsExtractColumns = [
    "Client",
    "FullName",
    "Email",
    "DateAdded",
    "LastLogin",
    "ActiveUser",
    "Third Party",
    "AccountAccess",
    "DocumentLibraryAccess",
    "CustomAccessAccess",
    "CustomAccessDetail",
    "DivisionAccess",
    "DivisionAccessDetail",
    "FacilityManager",
    "FacilityGRCFileNo",
    "Comments",
    "AutoRecCopyingOnly",
    "InitialEmail",
    "ReportEmail",
    "FirstFollowup",
    "SecondFollowup",
    "ThirdFollowup",
    "FirstOverdue",
    "SecondOverdue",
    "ThirdOverdue",
    "ExpdOverdue",
    "FilePrefix",
];

// A PLACEHOLDER FOR THE PRACTICES GRID IN USER RECLASSIFICATION FORM FOR 'All'
// NOT NEEDED FOR SERVER SIDE
var dsPracticeAll = {
    colFldId: 1,
    colFldPracticeCode: 000,
    colFldPracticeGroupCode: 00,
    colFldSortOrder: 1,
    colFldShortName: "All",
    colFldPracticeLetter: "A"
};

// DOWNLOAD OF CLIENT'S DYNAMIC PRACTICE LIST FOR AUTO REC GRID
var dsUserReclassPractices = {
    isSuccess: true,
    message: null,
    data: [
        {
            colFldId: 1,
            colFldPracticeCode: 000,
            colFldPracticeGroupCode: 00,
            colFldSortOrder: 1,
            colFldShortName: "All",
            colFldPracticeLetter: "A"
        }
    ]
};

// DOWNLOAD ON NEXT BUTTON OR PAGE LOAD
var dsUserReclassLoad = {
    isSuccess: true,
    message: null,
    data: [ // ONLY ONE RECORD NEEDED IN ARRAY PER PULL
		{
		    colUserIndex: 13,
		    colUserTotalCount: 25,
		    colUserCertifiedCount: 1,
		    colEzyGuid: "27d70395bdff4594a3260abd269381ab", // RECORD IDENTIFIER
		    colFullName: "Gary Kidney",
		    colActiveUser: "Active", // 'Status' ON THE FORM, DISPAL AS 'Active' OR 'Inactive'
		    colAccessLevel: "Division", // NEW FIELD
		    colAccessLevelDetails: "Division A", // NEW FIELD
		    colEmail: "gkidney@tuvam.com",
		    colCCOnly: "Yes", // DOWNLOAD AS A 'Yes' OR 'No'
		    colDateTimeStamp: "3-Aug-2016", // DOWNLOAD AS GRC FORMATTED DATE dd-MMM-yyyy
		    colLastLogin: "3-Aug-2016", // DOWNLOAD AS GRC FORMATTED DATE dd-MMM-yyyy
		    colComment: "This is a user comment.",
		    colClientComment: "This is a client comment.",
		    colRInit: "FBIWSLD",
		    colRReport: "FBIWSLD",
		    colRfu1: "FBIWSLD",
		    colRfu2: "FBIWSLD",
		    colRfu3: "FBIWSLD",
		    colROverdue1: "FBIWSLD",
		    colROverdue2: "FBIWSLD",
		    colROverdue3: "FBIWSLD",
		    colExpOverdue: "FBIWSLD",
		    colRExpd: "FBIWSLD",
		    colActionId: 1 // 0 = NONE, 1 = CONFIRM USER RECORD, 2 = INACTIVATE USER, 3 = DELETE USER RECORD
		}
    ]
};

// UPLOAD WHEN CLICKING NEXT OR BACK
var dsUserReclassSave = [
	{
		colUserIndex: 13,
		colUserTotalCount: 25,
		colUserCertifiedCount: 1,
		colEzyGuid: "27d70395bdff4594a3260abd269381ab", // RECORD IDENTIFIER
		colFullName: "Gary Kidney",
		colActiveUser: "Active", // 'Status' ON THE FORM, DISPAL AS 'Active' OR 'Inactive'
		colAccessLevel: "Division", // NEW FIELD
		colAccessLevelDetails: "Division A", // NEW FIELD
		colEmail: "gkidney@tuvam.com",
		colCCOnly: "Yes", // DOWNLOAD AS A 'Yes' OR 'No'
		colDateTimeStamp: "3-Aug-2016", // DOWNLOAD AS GRC FORMATTED DATE dd-MMM-yyyy
		colLastLogin: "3-Aug-2016", // DOWNLOAD AS GRC FORMATTED DATE dd-MMM-yyyy
		colComment: "This is a user comment.",
		colClientComment: "This is a client comment.",
		colRInit: "FBIWSLD",
		colRReport: "FBIWSLD",
		colRfu1: "FBIWSLD",
		colRfu2: "FBIWSLD",
		colRfu3: "FBIWSLD",
		colROverdue1: "FBIWSLD",
		colROverdue2: "FBIWSLD",
		colROverdue3: "FBIWSLD",
		colExpOverdue: "FBIWSLD",
		colRExpd: "FBIWSLD",
		colActionId: 1 // 0 = NONE, 1 = CONFIRM USER RECORD, 2 = INACTIVATE USER, 3 = DELETE USER RECORD
	}
];
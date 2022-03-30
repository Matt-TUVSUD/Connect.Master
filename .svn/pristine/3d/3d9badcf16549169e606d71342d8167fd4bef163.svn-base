<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Recommendations.aspx.vb" Inherits="GRC.Connect.Web.Recommendations" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>TÜV SÜD GRC Connect Knowledge Base</title>
	<link type="text/css" href="css/dashboardhelp.css" rel="stylesheet" />
</head>
<body>

    <h2>TÜV SÜD GRC Connect Knowledge Base - Recommendations Dashboard</h2>


    <div id="content" class="setPrimary">

        <div>
            <a href="DashboardHelp.aspx">Back to the general Knowledge Base for Dashboards</a>
        </div>
  
        <div id="contentInner">

            <div id="dashboardRecs" class="content">
                <h2>Recommendations Dashboard</h2>
                <p class="contentP">
                    The Recommendations Dashboard contains information about the recommendations that TÜV SÜD GRC has produced as a result of our inspections of your locations.  
                    The dashboard includes both outstanding and completed recommendations across all the services that we provide to your organization.
                </p>
                <p>
                    <img src="images/RecsDashboard.jpg" style="float:left;border:1px solid #CFD8DC" />
                </p>
                    <h4>Definitions</h4>
                    <ul style="float:left;width:40%;">
                    <li>
                        Active: A recommendation with a status of Outstanding, In Progress, or Advisory.
                    </li>
                    <li>
                        Closed: A recommendations with a status of Conf. Completed, Rptd. Completed, or Removed.  The year that a recommedation was closed is the year of the 
                        Status Date for Conf. Completed and Removed recommendations.  For Rptd. Completed recommendations, the year that a recommedation was closed is 
                        the year of the Response Date.
                    </li>
                    <li>
                        New: All recommendations, all statuses, in the year that the recommendation was opened.
                    </li>
                    <li>
                        Risk Improvement: For services other than Infrared, risk improvement is the sum of the recommendation's Loss Estimate Before minus the sum of the 
                        Loss Estimate After for Closed recommendations.  For Infrared, the risk improvement is a function of the recommendation's severity, where the more severe 
                        recommendations have a larger value for risk improvement once the recommendation has been closed.
                    </li>
                    </ul>
            </div>

            <div id="Rec1" class="content">
                <h3>New Recommendations Summary</h3>
                <p class="contentP">
                    The New Recommendations Summary shows risk improvement potential identified by TÜV SÜD GRC over the last five years.  The bars in this chart indicate the risk
                    identified in the year and the line indicates the number of recommendations identified during inspections completed in that year.
                </p>
                    <img src="images/RecsNewRecSummary.jpg"  style="float:left;border:1px solid #CFD8DC" />
                    <ul style="float:left;width:40%;">
                    <li>
                        Risk Identified = The sum of the Identified Risk for new recommendations grouped by the year the recommendation was created.
                    </li>
                    <li>
                        New Recommendations = All Recommendations, all statuses, grouped by the year the Recommendation was opened (RecYear).
                    </li>
                    <li>
                        Note: Calculations are the average of the Recommendation Loss Estimate Before and Loss Estimate After ranges (>1BIL is calculated using 1 Billion).              
                    </li>
                    </ul>
            </div>

            <div id="rec2" class="content">
                <h3>Risk Improvement</h3>
                <p class="contentP">
                    The Risk Improvement chart shows the total identified improvement (the number in the center of the "donut") along with the amount that has already been improved and that portion that is remaining.
                </p>
                    <img src="images/RecsRiskImprovement.jpg"  style="float:left;border:1px solid #CFD8DC" />
                    <ul style="float:left;width:40%;">
                    <li>
                        Identified = For all services other than Infrared, this is the sum of the Recommendations Loss Estimate Before minus the sum of the Loss Estimate After.  For Infrared, 
                        the risk identified is a function of the recommendation's severity.
                    </li>
                    <li>
                        Remaining = Total Identified minus the Identified for Closed Recommendations.
                    </li>
                    <li>
                        Improved = For services other than Infrared, risk improvement is the sum of the recommendation's Loss Estimate Before minus the sum of the 
                        Loss Estimate After for Closed recommendations.  For Infrared, the risk improvement is a function of the recommendation's severity, where the more severe 
                        recommendations have a larger value for risk improvement once the recommendation has been closed.
                    </li>
                    <li>
                        Note: Calculations are the average of the Recommendation Loss Estimate Before and Loss Estimate After ranges (>1BIL is calculated using 1 Billion).
                    </li>
                    </ul>
            </div>

            <div id="rec3" class="content">
                <h3>Closed Recommendation Summary</h3>
                <p class="contentP">
                    The Closed Recommendation Summary shows risk improvements completed over the last five years.  The bars in this chart indicate the risk
                    improvement that has been realized in the year and the line indicates the number of recommendations completed in that year.
                </p>
                    <img src="images/RecsClosedRecSummary.jpg"  style="float:left;border:1px solid #CFD8DC" />
                    <ul style="float:left;width:40%;">
                    <li>
                        Closed Recommendations = Recommendations with Conf. Completed, Rptd. Completed and Removed statuses, grouped by the Status Date Year of the closure.
                    </li>
                    <li>
                        Risk Improvement - See definition of "Risk Improvement", above.
                    </li>
                    <li>
                        Note: Calculations are the average of the Recommendation Loss Estimate Before and Loss Estimate After ranges (>1BIL is calculated using 1 Billion).
                    </li>
                    </ul>
            </div>

            <div id="rec4" class="content">
                <h3>Recommendations By Status</h3>
                <p class="contentP">
                    The Recommendations by Status chart shows the total number of recommendations for each status.
                </p>
                    <img src="images/RecsByStatus.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

            <div id="rec5" class="content">
                <h3>Recommendations By Impact</h3>
                <p class="contentP">
                    The Recommendations by Impact chart shows the total number of recommendations with a High, Moderate, or Low impact.
                </p>
                    <img src="images/RecsByImpact.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

            <div id="rec6" class="content">
                <h3>Recommendation Counts</h3>
                <p class="contentP">
                    The Recommendation Counts show the total number of recommendations and break that number down by service provided.
                </p>
                    <img src="images/RecsCount.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

            <div id="recTr" class="content">
                <h3>Trending</h3>
                <p class="contentP">
                    The Trending tab shows recommendation trending since the the very first recommendation was created by GRC
                    for your locations.
                </p>
                    <img src="images/RecTrending.jpg"  style="float:left;border:1px solid #CFD8DC" />
                    <ul style="float:left;width:40%;">
                    <li>Aggregation - This chart shows the number of recommendations that have been opened and closed over time.</li>
                    <li>
                        Recommendation History - This table lists the number of opened, closed, active, open all year, and percent closed recommendations by year.
                        <ul>
                            <li>Active 1-Jan - The number of recommendations that were active on January 1 of that year</li>
                            <li>New - The number of recommendations that were opened (created) during the year</li>
                            <li>Closed - The number of recommendations that were closed during the year</li>
                            <li>Active 31-Dec - The number of recommendations that were active on 1-Jan plus the number of New recommmendations minus the number of Closed recommendations</li>
                            <li>% closed - The percent of active recommendations that were Closed during the year (that is, the Closed column divided by the sum of 
                                the Active 1-Jan column and the New column, as a percent)</li>
                        </ul>
                    </li>
                    <li>New and Closed Totals - This chart shows the number of New recommendations and Closed recommendations by year.</li>
                    <li>Percent Closed by Year - This chart shows the percent of active recommendations that were closed by year.  A trend line helps to understand if the close-rate is increasing or decreasing.</li>
                    <li>Active Recommendation Counts - This chart shows the number of active recommendations at the beginning and end of each year.  The black line being above the green line indicates that more recommendations were closed during the year than opened.</li>
                    </ul>
            </div>

            <div id="rec7" class="content">
                <h3>Human Element Recommendations</h3>
                <p class="contentP">
                    The Human Element Recommendations chart shows the total number of human element recommendations separated by Secondary Rec Type.
                </p>
                    <img src="images/RecsHumanElement.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

            <div id="rec8" class="content">
                <h3>Recommendations by Primary Rec Type</h3>
                <p class="contentP">
                    The Recommendations by Primary Rec Type chart shows the total number of recommendations in each of the Primary Rec Types, excluding Human Element.
                </p>
                    <img src="images/RecsPrimaryRecType.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

            <div id="recLEI" class="content">
                <h3>Loss Estimates Improved</h3>
                <p class="contentP">
                    The Loss Estimates Improved tab shows information about recommendations that have been closed.
                </p>
                    <img src="images/RecsLossEstimatesImproved.jpg"  style="float:left;border:1px solid #CFD8DC" />
                    <ul style="float:left;width:40%;">
                        <li>Improved Recommendations by Status - This chart shows the total number of recommendations for each closed status.</li>
                        <li>Risk Improvement - This chart shows the total risk improvement.</li>
                        <li>Improved Recommendations by Primary Rec Type - This chart shows the total risk improvement of closed recommendations in each of the Primary Rec Types (excluding Human Element).
                            It shows the improvement by the year the recommendation was closed for each of the last five years 
                            (including the current year) with a separate bar containing the improvement for all previous years' closed recommendations.
                        </li>
                    </ul>
            </div>

            <div id="recLER" class="content">
                <h3>Loss Estimates Remaining</h3>
                <p class="contentP">
                    The Loss Estimates Remaining tab shows information about active recommendations.
                </p>
                    <img src="images/RecsLossEstimatesRemaining.jpg"  style="float:left;border:1px solid #CFD8DC" />
                    <ul style="float:left;width:40%;">
                        <li>Remaining Recommendations by Status - This chart shows the total number of recommendations for each active status.</li>
                        <li>Risk Improvement - This chart shows the total identified remaining improvement.</li>
                        <li>Remaining Recommendations by Primary Rec Type - This chart shows the total risk identified of active recommendations in each of the Primary Rec Types (excluding Human Element).
                            It shows the risk identified by the year the recommendation was created for each of the last five years 
                            (including the current year) with a separate bar containing the risk identified for all previous years' recommendations.
                        </li>
                    </ul>
            </div>

            <div id="recDiv" class="content">
                <h3>Recommendations by Division</h3>
                <p class="contentP">
                    The Recommendations by Division chart shows the Risk Improvement by division.
                </p>
                    <img src="images/RecsByDivision.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

            <div id="recCDI" class="content">
                <h3>Recommendations by Client Defined Identifier</h3>
                <p class="contentP">
                    The Recommendations by Client Defined Identifier chart shows the Risk Improvement by the client-defined field pre-defined by the client.
                </p>
                    <img src="images/RecsByClientDefinedIdentifier.jpg"  style="float:left;border:1px solid #CFD8DC" />
            </div>

        </div>
    </div>

</body>
</html>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BettingApplication.Models
{
  public class Fixtures
  {
    public class FixtureEntities : DbContext
    {
      public DbSet<Fixture> Fixtures { get; set; }
    }

    public class Self
    {
      public string href { get; set; }
    }

    public class Soccerseason
    {
      public string href { get; set; }
    }

    public class HomeTeam
    {
      public string href { get; set; }
    }

    public class AwayTeam
    {
      public string href { get; set; }
    }

    public class Links
    {
      public Self self { get; set; }
      public Soccerseason soccerseason { get; set; }
      public HomeTeam homeTeam { get; set; }
      public AwayTeam awayTeam { get; set; }
    }

    public class Result
    {
      public int goalsHomeTeam { get; set; }
      public int goalsAwayTeam { get; set; }
    }

    public class Fixture
    {
      public int id { get; set; }
      public Links _links { get; set; }
      public string date { get; set; }
      public object status { get; set; }
      public int matchday { get; set; }
      public string homeTeamName { get; set; }
      public string awayTeamName { get; set; }
      public Result result { get; set; }
    }

    public class Self2
    {
      public string href { get; set; }
    }

    public class Soccerseason2
    {
      public string href { get; set; }
    }

    public class HomeTeam2
    {
      public string href { get; set; }
    }

    public class AwayTeam2
    {
      public string href { get; set; }
    }

    public class Links2
    {
      public Self2 self { get; set; }
      public Soccerseason2 soccerseason { get; set; }
      public HomeTeam2 homeTeam { get; set; }
      public AwayTeam2 awayTeam { get; set; }
    }

    public class Result2
    {
      public int goalsHomeTeam { get; set; }
      public int goalsAwayTeam { get; set; }
    }

    public class LastHomeWinHomeTeam
    {
      public Links2 _links { get; set; }
      public string date { get; set; }
      public object status { get; set; }
      public int matchday { get; set; }
      public string homeTeamName { get; set; }
      public string awayTeamName { get; set; }
      public Result2 result { get; set; }
    }

    public class Self3
    {
      public string href { get; set; }
    }

    public class Soccerseason3
    {
      public string href { get; set; }
    }

    public class HomeTeam3
    {
      public string href { get; set; }
    }

    public class AwayTeam3
    {
      public string href { get; set; }
    }

    public class Links3
    {
      public Self3 self { get; set; }
      public Soccerseason3 soccerseason { get; set; }
      public HomeTeam3 homeTeam { get; set; }
      public AwayTeam3 awayTeam { get; set; }
    }

    public class Result3
    {
      public int goalsHomeTeam { get; set; }
      public int goalsAwayTeam { get; set; }
    }

    public class LastWinHomeTeam
    {
      public Links3 _links { get; set; }
      public string date { get; set; }
      public object status { get; set; }
      public int matchday { get; set; }
      public string homeTeamName { get; set; }
      public string awayTeamName { get; set; }
      public Result3 result { get; set; }
    }

    public class Self4
    {
      public string href { get; set; }
    }

    public class Soccerseason4
    {
      public string href { get; set; }
    }

    public class HomeTeam4
    {
      public string href { get; set; }
    }

    public class AwayTeam4
    {
      public string href { get; set; }
    }

    public class Links4
    {
      public Self4 self { get; set; }
      public Soccerseason4 soccerseason { get; set; }
      public HomeTeam4 homeTeam { get; set; }
      public AwayTeam4 awayTeam { get; set; }
    }

    public class Result4
    {
      public int goalsHomeTeam { get; set; }
      public int goalsAwayTeam { get; set; }
    }

    public class LastAwayWinAwayTeam
    {
      public Links4 _links { get; set; }
      public string date { get; set; }
      public object status { get; set; }
      public int matchday { get; set; }
      public string homeTeamName { get; set; }
      public string awayTeamName { get; set; }
      public Result4 result { get; set; }
    }

    public class Self5
    {
      public string href { get; set; }
    }

    public class Soccerseason5
    {
      public string href { get; set; }
    }

    public class HomeTeam5
    {
      public string href { get; set; }
    }

    public class AwayTeam5
    {
      public string href { get; set; }
    }

    public class Links5
    {
      public Self5 self { get; set; }
      public Soccerseason5 soccerseason { get; set; }
      public HomeTeam5 homeTeam { get; set; }
      public AwayTeam5 awayTeam { get; set; }
    }

    public class Result5
    {
      public int goalsHomeTeam { get; set; }
      public int goalsAwayTeam { get; set; }
    }

    public class LastWinAwayTeam
    {
      public Links5 _links { get; set; }
      public string date { get; set; }
      public object status { get; set; }
      public int matchday { get; set; }
      public string homeTeamName { get; set; }
      public string awayTeamName { get; set; }
      public Result5 result { get; set; }
    }

    public class Self6
    {
      public string href { get; set; }
    }

    public class Soccerseason6
    {
      public string href { get; set; }
    }

    public class HomeTeam6
    {
      public string href { get; set; }
    }

    public class AwayTeam6
    {
      public string href { get; set; }
    }

    public class Links6
    {
      public Self6 self { get; set; }
      public Soccerseason6 soccerseason { get; set; }
      public HomeTeam6 homeTeam { get; set; }
      public AwayTeam6 awayTeam { get; set; }
    }

    public class Result6
    {
      public int goalsHomeTeam { get; set; }
      public int goalsAwayTeam { get; set; }
    }

    public class Fixture2
    {
      public Links6 _links { get; set; }
      public string date { get; set; }
      public object status { get; set; }
      public int matchday { get; set; }
      public string homeTeamName { get; set; }
      public string awayTeamName { get; set; }
      public Result6 result { get; set; }
    }

    public class Head2head
    {
      public int count { get; set; }
      public string timeFrameStart { get; set; }
      public string timeFrameEnd { get; set; }
      public int homeTeamWins { get; set; }
      public int awayTeamWins { get; set; }
      public int draws { get; set; }
      public LastHomeWinHomeTeam lastHomeWinHomeTeam { get; set; }
      public LastWinHomeTeam lastWinHomeTeam { get; set; }
      public LastAwayWinAwayTeam lastAwayWinAwayTeam { get; set; }
      public LastWinAwayTeam lastWinAwayTeam { get; set; }
      public List<Fixture2> fixtures { get; set; }
    }

    public class RootObject
    {
      public Fixture fixture { get; set; }
      public Head2head head2head { get; set; }
    }

  }
}
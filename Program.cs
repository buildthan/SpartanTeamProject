
using SpartanTeamProject;

namespace TeamProject;

class Program
{
    static void Main(string[] args)
    {
        GameManager gm = new GameManager(); //생성자를 이용해 시작 데이터 세팅
        gm.MainScreen();
    }

}

class GameManager
{
    Player player;
    List<Monster> monsterList;

    public GameManager()
    {
        player = new Player(
            "Chad", //플레이어 이름
            1, //플레이어 레벨
            "전사", //플레이어 직업
            10, //플레이어 공격력
            5, //플레이어 방어력
            100, //플레이어 현재체력
            100, //플레이어 최대체력
            1500 //플레이어 소지골드
            );

    }

    public void MainScreen()
    {
        Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
        Console.WriteLine("이제 전투를 시작할 수 있습니다.");
        Console.WriteLine("");
        Console.WriteLine("1. 상태 보기");
        Console.WriteLine("2. 전투 시작");
        Console.WriteLine("");
        Console.WriteLine("원하시는 행동을 입력해주세요.");
        Console.WriteLine("");

        int input = ConsoleUtility.GetInput(1, 2);

        switch(input)
        {
            case 1:
                StatusScreen();
                break;
            case 2:
                BattleScreen();
                break;
        
        }

    }

    public void StatusScreen()
    {
    }

    public void BattleScreen()
    {
    }

}
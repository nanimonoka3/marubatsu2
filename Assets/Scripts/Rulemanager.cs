using UnityEngine;

namespace Script
{
    public class RuleManager
    {
        public static int[] MBstate = new int[9];// スコア変数,×→-1,〇→1,無印→0;
        public int turn;
        public RuleManager()
        {
            Init();
        }
        public void Init()
        {
            int[] MBstate = new int[9];
        }

        public void nextturn()
        {
            turn++;
        }
        public bool maruturn()
        {
            if (turn % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;

            }

        }
        public int judge()
        {
            //決着→ターン数を返す
            //引き分け→-1を返す
            //ゲーム続行→0を返す

            //勝ち判定
            if (MBstate[0] == MBstate[1]
                && MBstate[0] == MBstate[2]
                && MBstate[0] != 0)
            {
                return turn;
            }
            if (MBstate[3] == MBstate[4]
                && MBstate[3] == MBstate[5]
                && MBstate[3] != 0
                )
            {
                return turn;
            }
            if (MBstate[6] == MBstate[7]
                && MBstate[6] == MBstate[8]
                && MBstate[6] != 0
                )
            {
                return turn;
            }
            //ここまで横列
            if (MBstate[0] == MBstate[3]
                && MBstate[0] == MBstate[6]
                && MBstate[0] != 0
                )
            {
                return turn;
            }
            if (MBstate[1] == MBstate[4]
                && MBstate[1] == MBstate[7]
                && MBstate[1] != 0
                )
            {
                return turn;
            }
            if (MBstate[2] == MBstate[5]
                && MBstate[2] == MBstate[8]
                && MBstate[2] != 0
                )
            {
                return turn;
            }
            //ここまで縦列
            if (MBstate[0] == MBstate[4]
                && MBstate[0] == MBstate[8]
                && MBstate[0] != 0
                )
            {
                return turn;
            }
            if (MBstate[2] == MBstate[4]
                && MBstate[2] == MBstate[6]
                && MBstate[2] != 0
                )
            {
                return turn;
            }
            //ななめ
            if (turn == 9)
            {
                return -1;
            }
            //引き分け
            return 0;
        }
    }

}
namespace Script
{
    public class RuleManager
    {
        public static int[] IconState = new int[9];// スコア変数,×→-1,〇→1,無印→0;
        public int turn;
        public RuleManager()
        {
            Init();
        }
        public void Init()
        {
            int[] IconState = new int[9];
        }
        public bool MaruTurn()
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
        public void PutState(int index, int num)
        {
            IconState[index] = num;
        }

        public void PutIconState(int index)
        {
            if (MaruTurn() == true)
            {
                IconState[index] = -1;
            }
            else
            {
                IconState[index] = 1;
            }
        }
        public void AddTurn()
        {
            turn++;
        }
        public int Judge()
        {
            //決着→ターン数を返す
            //引き分け→-1を返す
            //ゲーム続行→0を返す

            //勝ち判定
            //横列
            if (IconState[0] == IconState[1]
                && IconState[0] == IconState[2]
                && IconState[0] != 0)
            {
                return turn;
            }
            if (IconState[3] == IconState[4]
                && IconState[3] == IconState[5]
                && IconState[3] != 0
                )
            {
                return turn;
            }
            if (IconState[6] == IconState[7]
                && IconState[6] == IconState[8]
                && IconState[6] != 0
                )
            {
                return turn;
            }
            //縦列
            if (IconState[0] == IconState[3]
                && IconState[0] == IconState[6]
                && IconState[0] != 0
                )
            {
                return turn;
            }
            if (IconState[1] == IconState[4]
                && IconState[1] == IconState[7]
                && IconState[1] != 0
                )
            {
                return turn;
            }
            if (IconState[2] == IconState[5]
                && IconState[2] == IconState[8]
                && IconState[2] != 0
                )
            {
                return turn;
            }
            //ななめ
            if (IconState[0] == IconState[4]
                && IconState[0] == IconState[8]
                && IconState[0] != 0
                )
            {
                return turn;
            }
            if (IconState[2] == IconState[4]
                && IconState[2] == IconState[6]
                && IconState[2] != 0
                )
            {
                return turn;
            }
            //引き分け
            if (turn >= 9)
            {
                return -1;
            }
            //続行
            else
            {
                return 0;
            }
        }
    }

}
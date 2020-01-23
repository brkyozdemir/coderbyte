            var num = 98;
            var result = 0;
            int[] myNum = Math.Abs(num).ToString().ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray();
            for (var j = 0; j < myNum.Length - 1; j++)
            {
                int[] myArr = shiftLeft(myNum);
                var finalNum = 0;
                for (var i = 0; i < myArr.Length; i++)
                {
                    finalNum += myArr[i] * Convert.ToInt32(Math.Pow(10, myArr.Length - i - 1));
                }
                for (var k = 2; k < finalNum; k++)
                {
                    if (finalNum % k == 0)
                    {
                        result = 0;
                        break;
                    }
                    else
                    {
                        result = 1;
                    }
                }
                if (result == 1)
                {
                    break;
                }
                myNum = myArr;
            }
            Console.Write(result);
            Console.ReadLine();
==============================================================================     
        public static int[] shiftLeft(int[] arr)
        {
            int[] demo = new int[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                demo[i] = arr[i + 1];
            }

            demo[demo.Length - 1] = arr[0];

            return demo;
        }

using System;
using System.Collections.Generic;

namespace YiJing
{
    class Program
    {
        static void Main(string[] args)
        {

            CastLines.printHexagram();
            
            //static
            //CastLines.yarrowStalks();


            //ikke-static
            //var yarrowStalksHexagram = new CastLines();

            //yarrowStalksHexagram.yarrowStalks();







            //List<string> yarrowPile = new List<string>();
            //Random rand = new Random();

            //// Populate pile list with 50 stalks.
            //for (int i = 0; i < 50; i++)
            //{
            //    yarrowPile.Add($"stalk_{i + 1}");
            //}

            //// Remove a random stalk, to have 49 remaining
            //int removeIndex = rand.Next(0, yarrowPile.Count - 1);
            //Console.WriteLine($"{yarrowPile[removeIndex]} is taken out of the pile.");
            //yarrowPile.RemoveAt(removeIndex);
            //Console.WriteLine($"{yarrowPile.Count} stalks remain in the pile.");

            //// Declare two pile variables to split the yarrowPile stalks.
            //List<string> leftPile = new List<string>();
            //List<string> rightPile = new List<string>();

            ////ROUND ONE OF THREE
            //Console.WriteLine("\nROUND ONE:");

            //// Randomly distribute the stalks into two piles.
            //for (int i = 0; i < yarrowPile.Count; i++)
            //{
            //    int randPile = rand.Next(0, 2);
            //    if (randPile == 0)
            //    {
            //        leftPile.Add(yarrowPile[i]);
            //    }
            //    else
            //    {
            //        rightPile.Add(yarrowPile[i]);
            //    }
            //}

            //yarrowPile.Clear();

            //Console.WriteLine("The stalks have been combined into two piles.");
            //Console.WriteLine($"The left pile contains {leftPile.Count} stalks");
            //Console.WriteLine($"The right pile contains {rightPile.Count} stalks");

            //// Take out a random stalk from the left pile, place it between the little finger and index finger of left hand
            //int randomRightPileStalkIndex = rand.Next(0, rightPile.Count - 1);
            //string randomRightPileStalk = rightPile[randomRightPileStalkIndex];
            //rightPile.RemoveAt(randomRightPileStalkIndex);
            //Console.WriteLine($"\n{randomRightPileStalk} was taken out from the right pile.\nIt has been placed" +
            //    $"between the little finger and index finger of the left hand.");
            //Console.WriteLine($"\nThe right pile now contains {rightPile.Count} stalks");

            //// Distribute the left pile into piles of four, until four or less stalks remain
            //Console.WriteLine("The left pile stalks will now be distributed into piles of four, until four or " +
            //    "fewer stalks remain");

            //List<string> leftTablePiles = new List<string>();
            //List<string> leftTableLeftovers = new List<string>();
            //if (leftPile.Count % 4 == 0)
            //{
            //    for (int i = 0; i < leftPile.Count - 4; i++)
            //    {
            //        leftTablePiles.Add(leftPile[i]);
            //    }

            //    leftPile.RemoveRange(0, leftPile.Count - 4);

            //    for (int i = 0; i < leftPile.Count; i++)
            //    {
            //        leftTableLeftovers.Add(leftPile[i]);
            //    }

            //    leftPile.Clear();
            //}
            //else
            //{
            //    int numLeftovers = leftPile.Count % 4;

            //    for (int i = 0; i < leftPile.Count-numLeftovers; i++)
            //    {
            //        leftTablePiles.Add(leftPile[i]);
            //    }

            //    leftPile.RemoveRange(0, leftPile.Count - numLeftovers);

            //    for (int i = 0; i < leftPile.Count; i++)
            //    {
            //        leftTableLeftovers.Add(leftPile[i]);
            //    }

            //    leftPile.Clear();
            //}

            //Console.WriteLine($"\nAfter distributing the left pile stalks into piles of four, {leftTableLeftovers.Count} " +
            //    $"stalk(s) remain. These are placed between the ring and middle fingers of the left hand.");

            //// Distribute the right pile into piles of four, until four or less stalks remain
            //Console.WriteLine("\nThe right pile stalks will now be distributed into piles of four, until four or " +
            //   "fewer stalks remain");

            //List<string> rightTablePiles = new List<string>();
            //List<string> rightTableLeftovers = new List<string>();
            //if (rightPile.Count % 4 == 0)
            //{
            //    for (int i = 0; i < rightPile.Count - 4; i++)
            //    {
            //        rightTablePiles.Add(rightPile[i]);
            //    }

            //    rightPile.RemoveRange(0, rightPile.Count - 4);

            //    for (int i = 0; i < rightPile.Count; i++)
            //    {
            //        rightTableLeftovers.Add(rightPile[i]);
            //    }

            //    rightPile.Clear();
            //}
            //else
            //{
            //    int numLeftovers = rightPile.Count % 4;

            //    for (int i = 0; i < rightPile.Count - numLeftovers; i++)
            //    {
            //        rightTablePiles.Add(rightPile[i]);
            //    }

            //    rightPile.RemoveRange(0, rightPile.Count - numLeftovers);

            //    for (int i = 0; i < rightPile.Count; i++)
            //    {
            //        rightTableLeftovers.Add(rightPile[i]);
            //    }

            //    rightPile.Clear();
            //}

            //Console.WriteLine($"\nAfter distributing the right pile stalks into piles of four, {rightTableLeftovers.Count} " +
            //    $"stalk(s) remain. These are placed between the middle and index fingers of the left hand.");

            //int combinedTableLeftoversFirstRound = leftTableLeftovers.Count + rightTableLeftovers.Count + 1;

            //Console.WriteLine($"\nYour left hand now contains a total of " +
            //    $"{combinedTableLeftoversFirstRound} stalks.");

            //Console.WriteLine($"\nThe {combinedTableLeftoversFirstRound} counted stalks in the left hand " +
            //    $"are put aside. The table piles of sets of four stalks are collected and again split into two piles.");

            //leftTableLeftovers.Clear();
            //rightTableLeftovers.Clear();

            //foreach (var stalk in leftTablePiles)
            //{
            //    yarrowPile.Add(stalk);
            //}

            //leftTablePiles.Clear();

            //foreach (var stalk in rightTablePiles)
            //{
            //    yarrowPile.Add(stalk);
            //}

            //rightTablePiles.Clear();

            //Console.WriteLine($"\nThe table piles have been collected to a single pile of {yarrowPile.Count} stalks");
            ////yarrowPile.ForEach(Console.WriteLine);

            //// ROUND TWO OF THREE
            //Console.WriteLine("\nSECOND ROUND:");

            //// Randomly distribute the stalks into two piles.
            //for (int i = 0; i < yarrowPile.Count; i++)
            //{
            //    int randPile = rand.Next(0, 2);
            //    if (randPile == 0)
            //    {
            //        leftPile.Add(yarrowPile[i]);
            //    }
            //    else
            //    {
            //        rightPile.Add(yarrowPile[i]);
            //    }
            //}

            //yarrowPile.Clear();

            //Console.WriteLine("\nThe pile have been split into two piles.");
            //Console.WriteLine($"\nThe left pile contains {leftPile.Count} stalks");
            //Console.WriteLine($"\nThe right pile contains {rightPile.Count} stalks");

            //randomRightPileStalkIndex = rand.Next(0, rightPile.Count - 1);
            //randomRightPileStalk = rightPile[randomRightPileStalkIndex];
            //rightPile.RemoveAt(randomRightPileStalkIndex);
            //Console.WriteLine($"\n{randomRightPileStalk} was taken out from the right pile.\nIt has been placed" +
            //                $"between the little finger and index finger of the left hand.");

            //// Distribute the left pile into piles of four, until four or fewer stalks remain
            //Console.WriteLine("\nThe left pile stalks will now be distributed into piles of four, until four or " +
            //    "fewer stalks remain");

            //if (leftPile.Count % 4 == 0)
            //{
            //    for (int i = 0; i < leftPile.Count - 4; i++)
            //    {
            //        leftTablePiles.Add(leftPile[i]);
            //    }

            //    leftPile.RemoveRange(0, leftPile.Count - 4);

            //    for (int i = 0; i < leftPile.Count; i++)
            //    {
            //        leftTableLeftovers.Add(leftPile[i]);
            //    }

            //    leftPile.Clear();
            //}
            //else
            //{
            //    int numLeftovers = leftPile.Count % 4;

            //    for (int i = 0; i < leftPile.Count - numLeftovers; i++)
            //    {
            //        leftTablePiles.Add(leftPile[i]);
            //    }

            //    leftPile.RemoveRange(0, leftPile.Count - numLeftovers);

            //    for (int i = 0; i < leftPile.Count; i++)
            //    {
            //        leftTableLeftovers.Add(leftPile[i]);
            //    }

            //    leftPile.Clear();
            //}

            //Console.WriteLine($"\nAfter distributing the left pile stalks into piles of four, {leftTableLeftovers.Count} " +
            //    $"stalk(s) remain. These are placed between the ring and middle fingers of the left hand.");

            //// Distribute the right pile into piles of four, until four or less stalks remain
            //Console.WriteLine("\nThe right pile stalks will now be distributed into piles of four, until four or " +
            //   "less stalks remain");

            //if (rightPile.Count % 4 == 0)
            //{
            //    for (int i = 0; i < rightPile.Count - 4; i++)
            //    {
            //        rightTablePiles.Add(rightPile[i]);
            //    }

            //    rightPile.RemoveRange(0, rightPile.Count - 4);

            //    for (int i = 0; i < rightPile.Count; i++)
            //    {
            //        rightTableLeftovers.Add(rightPile[i]);
            //    }

            //    rightPile.Clear();
            //}
            //else
            //{
            //    int numLeftovers = rightPile.Count % 4;

            //    for (int i = 0; i < rightPile.Count - numLeftovers; i++)
            //    {
            //        rightTablePiles.Add(rightPile[i]);
            //    }

            //    rightPile.RemoveRange(0, rightPile.Count - numLeftovers);

            //    for (int i = 0; i < rightPile.Count; i++)
            //    {
            //        rightTableLeftovers.Add(rightPile[i]);
            //    }

            //    rightPile.Clear();
            //}

            //Console.WriteLine($"\nAfter distributing the right pile stalks into piles of four, {rightTableLeftovers.Count} " +
            //    $"stalk(s) remain. These are placed between the middle and index fingers of the left hand.");

            //int combinedTableLeftoversSecondRound = leftTableLeftovers.Count + rightTableLeftovers.Count + 1;

            //Console.WriteLine($"\nYour left hand now contains a total of {combinedTableLeftoversSecondRound} stalks.");

            //Console.WriteLine($"\nThe {combinedTableLeftoversSecondRound} counted stalks in the left hand " +
            //    $"are put aside. The table piles of sets of four stalks are collected and again split into two piles.");

            //leftTableLeftovers.Clear();
            //rightTableLeftovers.Clear();

            //foreach (var stalk in leftTablePiles)
            //{
            //    yarrowPile.Add(stalk);
            //}

            //leftTablePiles.Clear();

            //foreach (var stalk in rightTablePiles)
            //{
            //    yarrowPile.Add(stalk);
            //}

            //rightTablePiles.Clear();

            //Console.WriteLine($"\nThe table piles have been collected to a single pile of {yarrowPile.Count} stalks");
            ////yarrowPile.ForEach(Console.WriteLine);

            ////ROUND THREE OF THREE
            //Console.WriteLine("\nTHIRD ROUND:");

            //// Randomly distribute the stalks into two piles.
            //for (int i = 0; i < yarrowPile.Count; i++)
            //{
            //    int randPile = rand.Next(0, 2);
            //    if (randPile == 0)
            //    {
            //        leftPile.Add(yarrowPile[i]);
            //    }
            //    else
            //    {
            //        rightPile.Add(yarrowPile[i]);
            //    }
            //}

            //yarrowPile.Clear();

            //Console.WriteLine("\nThe pile have been split into two piles.");
            //Console.WriteLine($"\nThe left pile contains {leftPile.Count} stalks");
            //Console.WriteLine($"\nThe right pile contains {rightPile.Count} stalks");

            //Console.WriteLine("\nOne of the right pile stalks will be taken out and placed between" +
            //    "the little finger and index finger of the left hand.");
            //randomRightPileStalkIndex = rand.Next(0, rightPile.Count - 1);
            //randomRightPileStalk = rightPile[randomRightPileStalkIndex];
            //rightPile.RemoveAt(randomRightPileStalkIndex);
            //Console.WriteLine($"\n{randomRightPileStalk} was taken out from the right pile.\nIt has been placed" +
            //                $"between the little finger and index finger of the left hand.");

            //// Distribute the left pile into piles of four, until four or less stalks remain
            //Console.WriteLine("\nThe left pile stalks will now be distributed into piles of four, until four or " +
            //    "fewer stalks remain");

            //if (leftPile.Count % 4 == 0)
            //{
            //    for (int i = 0; i < leftPile.Count - 4; i++)
            //    {
            //        leftTablePiles.Add(leftPile[i]);
            //    }

            //    leftPile.RemoveRange(0, leftPile.Count - 4);

            //    for (int i = 0; i < leftPile.Count; i++)
            //    {
            //        leftTableLeftovers.Add(leftPile[i]);
            //    }

            //    leftPile.Clear();
            //}
            //else
            //{
            //    int numLeftovers = leftPile.Count % 4;

            //    for (int i = 0; i < leftPile.Count - numLeftovers; i++)
            //    {
            //        leftTablePiles.Add(leftPile[i]);
            //    }

            //    leftPile.RemoveRange(0, leftPile.Count - numLeftovers);

            //    for (int i = 0; i < leftPile.Count; i++)
            //    {
            //        leftTableLeftovers.Add(leftPile[i]);
            //    }

            //    leftPile.Clear();
            //}

            //Console.WriteLine($"\nAfter distributing the left pile stalks into piles of four, {leftTableLeftovers.Count} " +
            //    $"stalk(s) remain. These are placed between the ring and middle fingers of the left hand.");

            //// Distribute the right pile into piles of four, until four or less stalks remain
            //Console.WriteLine("\nThe right pile stalks will now be distributed into piles of four, until four or " +
            //   "fewer stalks remain");

            //if (rightPile.Count % 4 == 0)
            //{
            //    for (int i = 0; i < rightPile.Count - 4; i++)
            //    {
            //        rightTablePiles.Add(rightPile[i]);
            //    }

            //    rightPile.RemoveRange(0, rightPile.Count - 4);

            //    for (int i = 0; i < rightPile.Count; i++)
            //    {
            //        rightTableLeftovers.Add(rightPile[i]);
            //    }

            //    rightPile.Clear();
            //}
            //else
            //{
            //    int numLeftovers = rightPile.Count % 4;

            //    for (int i = 0; i < rightPile.Count - numLeftovers; i++)
            //    {
            //        rightTablePiles.Add(rightPile[i]);
            //    }

            //    rightPile.RemoveRange(0, rightPile.Count - numLeftovers);

            //    for (int i = 0; i < rightPile.Count; i++)
            //    {
            //        rightTableLeftovers.Add(rightPile[i]);
            //    }

            //    rightPile.Clear();
            //}

            //Console.WriteLine($"\nAfter distributing the right pile stalks into piles of four, {rightTableLeftovers.Count} " +
            //    $"stalk(s) remain. These are placed between the middle and index fingers of the left hand.");

            //int combinedTableLeftoversThirdRound = leftTableLeftovers.Count + rightTableLeftovers.Count + 1;

            //Console.WriteLine($"\nYour left hand now contains a total of {combinedTableLeftoversThirdRound} stalks.");

            //Console.WriteLine($"\nThe {combinedTableLeftoversThirdRound} counted stalks in the left hand " +
            //    $"are put aside. The table piles of sets of four stalks are collected and again split into two piles.");

            //leftTableLeftovers.Clear();
            //rightTableLeftovers.Clear();

            //// Assigning value to results
            //int valueFirstRound = (combinedTableLeftoversFirstRound == 9 ? 2 : 3);
            //int valueSecondRound = (combinedTableLeftoversSecondRound == 8 ? 2 : 3);
            //int valueThirdRound = (combinedTableLeftoversThirdRound == 8 ? 2 : 3);
            //int combinedValue = valueFirstRound + valueSecondRound + valueThirdRound;

            //string yinYangName = "";
            //string symbolLine = "";
            //switch(combinedValue)
            //{
            //    case 6:
            //        yinYangName = "old yin";
            //        symbolLine = "---x---";
            //        break;
            //    case 8:
            //        yinYangName = "young yin";
            //        symbolLine = "--- ---";
            //        break;
            //    case 9:
            //        yinYangName = "old yang";
            //        symbolLine = "---o---";
            //        break;
            //    case 7:
            //        yinYangName = "young yang";
            //        symbolLine = "-------";
            //        break;
            //}


            //Console.WriteLine($"Value of ValueFristRound = {valueFirstRound}");
            //Console.WriteLine($"Value of ValueSecondRound = {valueSecondRound}");
            //Console.WriteLine($"Value of ValueThirdRound = {valueThirdRound}");

            //Console.WriteLine("\nThe Yin-Yang name and symbol line are:");
            //Console.WriteLine($"\n{yinYangName}");
            //Console.WriteLine($"\n{symbolLine}");

            //Console.WriteLine("\nSUMMARY OF LEFTOVER STALKS:");

            //Console.WriteLine($"FIRST ROUND: {combinedTableLeftoversFirstRound}");
            //Console.WriteLine($"SECOND ROUND: {combinedTableLeftoversSecondRound}");
            //Console.WriteLine($"THIRD ROUND: {combinedTableLeftoversThirdRound}");


        }
    }
}

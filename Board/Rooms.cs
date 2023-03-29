using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Threading_in_C.Board.placeable;

namespace Threading_in_C.Board
{
    public static class Rooms
    {
        private static void drawRoom(List<Point> wallList)
        {
            foreach (Point point in wallList)
            {
                Console.WriteLine("Yeet");
                Tile tile2 = (Tile)PlayerBoard.intsance.tileArray[point.Y, point.X].Tag;
                tile2.setPlaceable(new Obstacle("Wall"));

                PlayerBoard.intsance.updateBoard();
            }
        }

        public static void placeRoom1(int x, int y)
        {
            List<Point> wallList = new List<Point>();;

            wallList.Add(new Point(x,y));
            wallList.Add(new Point(x + 1, y));
            wallList.Add(new Point(x + 3, y));
            wallList.Add(new Point(x + 4, y + 1));
            wallList.Add(new Point(x + 4, y + 3));
            wallList.Add(new Point(x + 3, y + 4));
            wallList.Add(new Point(x + 2, y + 4));
            wallList.Add(new Point(x + 1, y + 4));
            wallList.Add(new Point(x, y + 4));
            wallList.Add(new Point(x, y + 2));
            wallList.Add(new Point(x, y + 1));
            wallList.Add(new Point(x, y + 0));

            drawRoom(wallList);
        }

        public static void placeRoom2()
        {

        }

        public static void placeRoom3()
        {

        }

        public static void placeRoom4()
        {

        }

        public static void placeRoom5()
        {


        }
    }
}

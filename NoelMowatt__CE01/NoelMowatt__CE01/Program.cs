using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt__CE01
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Instantiation of Rock Class
            Rock rock = new Rock(texture:"rough",roll:false,numOfSides:11);
            string surface = rock.GS_texture;
            bool canRoll = rock.GS_roll;
            int numSides = rock.GS_numOfSides;

            surface = "smooth";
            canRoll = true;
            numSides = 1;

            //--Instantiation of Paper Class
            Paper paper = new Paper(color: "white", numOfSheets: 1, isPrintingPaper: true);
            string kolor = paper.GS_color;
            int numSheets = paper.GS_numOfSheets;
            bool printable = paper.GS_printablePaper;

            kolor = "Night Blue";
            numSheets = 28;
            printable = true;

            //--Instantiation of Scissors Class
            Scissors scissors = new Scissors(isSharp: true, materialOfHandle: "Rubber", numOfBlades: 2);
            bool sharp = scissors.GS_isSharp;
            string handleMaterial = scissors.GS_materialOfhandle;
            int numBlades = scissors.GS_numBlades;

            sharp = true;
            handleMaterial = "Recycled Rubber";
            numBlades = 2;
        }
    }
}

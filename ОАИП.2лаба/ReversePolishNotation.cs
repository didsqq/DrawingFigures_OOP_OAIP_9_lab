using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОАИП._2лаба.Фигуры;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ОАИП._2лаба
{
    public static class ReversePolishNotation
    {
        public static bool CalculateRPN(string expression)
        {
            Stack<string> operandsStack = new Stack<string>();
            string bufer = "";
            foreach (char c in expression)
            {
                if (Char.IsDigit(c))
                {
                    bufer += c;
                }
                else if (IsOperator(c))
                {
                    if (ApplyOperation(operandsStack, c))
                        return true;
                    else
                        return false;
                }
                else if(c == ';')
                {
                    operandsStack.Push(bufer);
                    bufer = "";
                }
                else 
                {
                    bufer += c;
                }
            }
            return false;
        }
        private static bool IsOperator(char c)
        {
            return c == 'E' || c == 'M' || c == 'D';
        }
        private static bool ApplyOperation(Stack<string>operands, char c)
        {
            if(c == 'E' && operands.Count == 5)
            {
                string name = operands.Peek().ToString();
                foreach (Ellipse fig in ShapeContainer.figureListRPN)
                    if (fig.name == name)
                        return false;
                Ellipse ellipse = new Ellipse(operands.Pop().ToString(), 
                    int.Parse(operands.Pop()), 
                    int.Parse(operands.Pop()), 
                    int.Parse(operands.Pop()), 
                    int.Parse(operands.Pop()));
                
                if (ellipse.EllipseDraw())
                {
                    ShapeContainer.AddFigureRPN(ellipse);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (c == 'M' && operands.Count == 3)
            {
                string name = operands.Pop().ToString();
                foreach (Ellipse fig in ShapeContainer.figureListRPN)
                {
                    if (fig.name == name)
                    {
                        if(fig.EllipseMoveTo(int.Parse(operands.Pop()), int.Parse(operands.Pop()), ShapeContainer.figureListRPN.IndexOf(fig)))
                            return true;
                        else
                            return false;
                    }
                }
                return false;
            }
            else if (c == 'D' && operands.Count == 1)
            {
                string name = operands.Pop().ToString();
                foreach (Ellipse fig in ShapeContainer.figureListRPN)
                {
                    if (fig.name == name)
                    { 
                        ShapeContainer.figureListRPN.Remove(fig);
                        Ellipse.EllipseDeleteF(fig);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}

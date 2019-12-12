using System;
using System.Collections.Generic;
using System.Text;

namespace ThatGame
{
    class GridSystem
    {
        public void buildBoxList(List<ContentBox> items, int activeBox = 0, int activeChoice = 0) {
            int itemCount = items.Count;
            TextAlignments _align = new TextAlignments();
            Commands command = new Commands();
            if (activeBox < 0) {
                activeBox = 0;
            }else if (activeBox > itemCount){
                activeBox = itemCount;
            }

            if (activeChoice > items[activeBox].content.Count) {
                activeChoice = items[activeBox].content.Count;
            } else if (activeChoice < 0) {
                activeChoice = 0;
            }

            List<ContentBox> list = getActiveBoxes(items, activeBox);
            for (int i = 1; i <= list.Count; i++) {
                if (items.IndexOf(list[i - 1]) == activeBox)
                {
                    command.printCommands(list[i -1], false, (40 * i), 15, ConsoleColor.DarkGray);
                    //_align.boxContent(list[i - 1], (40 * i), 15, ConsoleColor.DarkGray);
                }
                else {

                    command.printCommands(list[i - 1], false, (40 * i), 15);
                    //_align.boxContent(list[i - 1], (40 * i), 15);
                }
                
            }
        }

        private List<ContentBox> getActiveBoxes(List<ContentBox> items, int activeBox) {
            List<ContentBox> result = new List<ContentBox>();

            if ((activeBox - 1) >= 0)
            {
                result.Add(items[(activeBox - 1)]);
                result.Add(items[activeBox]);
                if ((activeBox + 1) <= items.Count)
                {
                    result.Add(items[(activeBox + 1)]);
                }
            }
            else {
                result.Add(items[activeBox]);
                if ((activeBox + 1) <= items.Count) {
                    result.Add(items[(activeBox + 1)]);
                    if ((activeBox + 2) <= items.Count) {
                        result.Add(items[(activeBox + 2)]);
                    }
                }
            }

            return result;
        }
    }
}

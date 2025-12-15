/*******************************************
 * 
 * Copyright (c) High School Blek, 2025
 * 
 * File:        UtilList.cs
 * Author:      JustDrven
 * 
 *******************************************/

namespace praxe_desktop_client.Utilities
{
    internal class UtilList
    {

        public static void Clear(ListBox list)
        {
            if (list == null) return;

            var items = list.Items;
            if (items.Count == 0) return;

            items.Clear();

        }


        public static void ClearMap<TKey, TData>(Dictionary<TKey, TData>? map)
        {
            if (map == null) return;
            if (map.Count == 0) return;

            map.Clear();

        }

        public static void SetContent(ListBox list, Action a)
        {
            if (list == null) return;
            Clear(list);



            a.Invoke();

        }

    }
}

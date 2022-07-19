using System;

public class App
{
	public App()
	{
	}
	public void Add(string s,CheckedListBox list)
    {
		list.Items.Add(s);
    }
	public void remove(CheckedListBox list)
    {
		for (int i = 0; i < list.Items.Count; i++)
			list.Items.Remove(list.Items[i]);
    }
}

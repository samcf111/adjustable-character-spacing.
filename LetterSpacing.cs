    string str = text.text;
     
    // Artificially insert line breaks for automatic line breaks.
    IList<UILineInfo> lineInfos = text.cachedTextGenerator.lines;
    for(int i = lineInfos.Count - 1; i > 0; i--)
    {
        // Insert a \n at the location Unity wants to automatically line break.
        // Also, remove any space before the automatic line break location.
        str = str.Insert(lineInfos[i].startCharIdx, "\n");
        str = str.Remove(lineInfos[i].startCharIdx - 1, 1);
    }
     
    string[] lines = str.Split('\n');
    // Rest of the code down here.

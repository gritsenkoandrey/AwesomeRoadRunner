using System.Collections.Generic;

public static class TagHelper
{
    private static readonly Dictionary<TagType, string> _tags;

    static TagHelper()
    {
        _tags = new Dictionary<TagType, string>
        {
            { TagType.Road, "Road" },
            { TagType.TopNearGrass, "TopNearGrass" },
            { TagType.TopFarGrass, "TopFarGrass" },
            { TagType.BottomNearGrass, "BottomNearGrass" },
            { TagType.BottomFarLandOne, "BottomFarLandOne" },
            { TagType.BottomFarLandTwo, "BottomFarLandTwo" },
            { TagType.BottomFarLandThree, "BottomFarLandThree" },
            { TagType.BottomFarLandFour, "BottomFarLandFour" },
            { TagType.BottomFarLandFive, "BottomFarLandFive" },
            { TagType.Obstacle, "Obstacle" },
            { TagType.Star, "Star" },
            { TagType.StarEffect, "StarEffect" },
            { TagType.ObTop, "ObTop" },
            { TagType.ObBottom, "ObBottom" },
            { TagType.ObMidle, "ObMidle" },
            { TagType.TRex, "TRex" },
            { TagType.SortingLayerTopNearGround, "TopNearGround" },
            { TagType.SortingLayerTreeTop, "TreeTop" },
            { TagType.SortingLayerBottomNearGround, "BottomNearGround" },
            { TagType.SortingLayerTreeBottom, "TreeBottom" }
        };
    }

    public static string GetTag(TagType tagType)
    {
        return _tags[tagType];
    }
}
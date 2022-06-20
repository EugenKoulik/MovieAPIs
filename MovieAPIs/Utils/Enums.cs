﻿namespace MovieAPIs.Utils
{ 

    public enum Tops
    {
        TOP_250_BEST_FILMS,
        TOP_100_POPULAR_FILMS,
        TOP_AWAIT_FILMS
    }

    public enum MovieOrder
    {
        RATING,
        NUM_VOTE,
        YEAR
    }
    public enum MovieType
    {
        FILM,
        TV_SHOW,
        TV_SERIES,
        MINI_SERIES,
        ALL
    }

    public enum Filter
    {
        ALL = -1
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace tp_synthese.Classes
{
    class Comment
    {
        public int Id;
        public Post post;
        public int UserId;
        public string Texte;
        public string ImageUrl;
        public string StickerUrl;

        public Reaction Reaction;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateACD_12_10_21
{
    class CD
    {
        string cdTitle;
        int tracks;
        float[] trackLengths;
        //Constructor - allows a new CD Object to be constructed, that is a new CD instance to be made
        public CD(string title,int nTracks, float[] tLengths)
        {
            cdTitle = title;
            tracks = nTracks;
            trackLengths = tLengths;
        }

        public string Title { get {return cdTitle; }  }

        public int NTracks { get { return tracks; } }

        public float TrackLength(int tn)
        {
            return trackLengths[tn];
        }
    }
}

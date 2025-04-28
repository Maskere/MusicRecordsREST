namespace DRMusic{
    public class MusicRecord{
        private string? title;
        private string? artist;
        private int duration;
        private int publication_year;

        public MusicRecord(){
        }

        public MusicRecord(string? title, string? artist, int duration,int publication_year){
            Title = title;
            Artist = artist;
            Duration = duration;
            Publication_year = publication_year;
        }

        public string? Title{
            get => title;
            set{
                title = value;
            }
        }

        public string? Artist{
            get => artist;
            set{
                artist = value;
            }
        }

        public int Duration{
            get => duration;
            set{
                duration = value;
            }
        }

        public int Publication_year{
            get => publication_year;
            set{
                publication_year = value;
            }
        }
        public override string ToString()
        {
            return "";
        }
    }
}

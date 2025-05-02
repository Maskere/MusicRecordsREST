namespace DRMusic{
    public class MusicRecordModel{
        private int id;
        private string? title;
        private string? artist;
        private int duration;
        private int publication_year;

        public MusicRecordModel() : this("","",0,0){
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            Publication_year = publication_year;
        }

        public MusicRecordModel(string? title, string? artist, int duration,int publication_year){
            Id = id;
            Title = title;
            Artist = artist;
            Duration = duration;
            Publication_year = publication_year;
        }

        public int Id{
            get => id;
            set{
                id = value;
            }
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
            return $"Title: {Title}, Artist: {Artist}, Duration: {Duration}, Publication Year: {Publication_year}";
        }
    }
}

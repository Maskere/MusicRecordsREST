namespace DRMusic{
    public class MusicRecordRepository{
        private List<MusicRecordModel> records = new();

        public MusicRecordRepository(){
            records.Add(new MusicRecordModel("DreadNought","Sabaton", 3, 2009));
            records.Add(new MusicRecordModel("American Idiot","Green-Day", 3, 2002));
            records.Add(new MusicRecordModel("Run to the hills","IronMaiden", 5, 1999));
            records.Add(new MusicRecordModel("Number of the beast","IronMaiden", 6, 2000));
        }

        public List<MusicRecordModel>? Get(string? title = null, string? artist = null, int? duration = null, int? publication_year = null){
            if(title != null){
                return records.FindAll(m => m.Title == title);
            }

            if(artist != null){
                return records.FindAll(m => m.Artist == artist);
            }

            if(duration != null){
                return records.FindAll(m => m.Duration == duration);
            }

            if(publication_year != null){
                return records.FindAll(m => m.Publication_year == publication_year);
            }

            if(records == null){
                throw new ArgumentNullException("Collection is empty");
            }
            return new List<MusicRecordModel>(records);
        }
    }
}

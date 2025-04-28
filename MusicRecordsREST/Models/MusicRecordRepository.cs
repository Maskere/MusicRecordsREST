namespace DRMusic{
    public class MusicRecordRepository{
        private List<MusicRecord> records = new();

        public MusicRecordRepository(){
            records.Add(new MusicRecord("DreadNought","Sabaton", 3, 2009));
            records.Add(new MusicRecord("American Idiot","Green-Day", 3, 2002));
            records.Add(new MusicRecord("Run to the hills","IronMaiden", 5, 1999));
            records.Add(new MusicRecord("Number of the beast","IronMaiden", 6, 2000));
        }

        public List<MusicRecord>? Get(string? title = null, string? artist = null, int? duration = null, int? publication_year = null){
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

            return new List<MusicRecord>(records);
        }
    }
}

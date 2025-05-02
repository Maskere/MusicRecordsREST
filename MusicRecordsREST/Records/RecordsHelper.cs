namespace DRMusic
{

    public record MusicRecord(string? Title, string? Artist, int? Duration, int? Publication_year);
   
    public static class RecordsHelper
    {
        public static MusicRecordModel ConvertDRMusicRecord(MusicRecord record)
        {
            if (record.Title == null)
            {
                throw new ArgumentNullException(nameof(record.Title), "Record cannot be null");
            }
            if (record.Artist == null)
            {
                throw new ArgumentException("Title cannot be null or empty", nameof(record.Artist));
            }
            if (record.Duration == null)
            {
                throw new ArgumentException("Artist cannot be null or empty", nameof(record.Duration));
            }
            if (record.Publication_year == null)
            {
                throw new ArgumentException("Duration cannot be null or empty", nameof(record.Publication_year));
            }
            return new MusicRecordModel() {
                Title = record.Title,
                Artist = record.Artist,
                Duration = (int)record.Duration,
                Publication_year = (int)record.Publication_year
            };
        }
            
        
    }
}

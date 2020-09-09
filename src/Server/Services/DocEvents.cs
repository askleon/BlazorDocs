using System;

namespace Server
{
    public class DocEvents
    {
        public event Action<DocDto> OnNewDoc;
        public event Action<DocDto> OnUpdatedDoc;
        public event Action<DocDto> OnDeletedDoc;
        public void NewDoc(DocDto dto) => OnNewDoc?.Invoke(dto);
        public void UpdateDoc(DocDto dto) => OnUpdatedDoc?.Invoke(dto);
        public void DeletedDoc(DocDto dto) => OnDeletedDoc?.Invoke(dto);
    }
}
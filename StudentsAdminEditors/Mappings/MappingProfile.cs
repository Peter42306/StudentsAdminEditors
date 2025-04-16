using AutoMapper;
using StudentsAdminEditors.Models;
using StudentsAdminEditors.ViewModels;

namespace StudentsAdminEditors.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentViewModel>()
                .ForMember(dest => dest.ExistingPhotoPath, opt => opt.MapFrom(src => src.PhotoPath));

            CreateMap<StudentViewModel, Student>()
                .ForMember(dest => dest.PhotoPath, opt => opt.Ignore());
        }
    }
}

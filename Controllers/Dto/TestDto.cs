using AttributeTask2.Validation;

namespace AttributeTask2.Controllers.Dto
{
    public class TestDto
    {
        [NotNullOrDefaultValidation]
        public int NotNullableInt { get; set; }

        [NotNullOrDefaultValidation]
        public int? NullableInt { get; set; }

        [NotNullOrDefaultValidation]
        public string String { get; set; }

        [NotNullOrDefaultValidation]
        public Foo Foo { get; set; }
    }

    public class Foo
    {
        public int Count { get; set; }
    }
}

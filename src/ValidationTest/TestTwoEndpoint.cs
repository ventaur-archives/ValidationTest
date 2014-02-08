using FubuValidation;


namespace ValidationTest {
	public class TestTwoEndpoint {
		public TestTwoInputModel Get_Test_Two(TestTwoRequestModel request) {
			return new TestTwoInputModel();
		}

		public TestTwoInputModel Post_Test_Two(TestTwoInputModel input) {
			return input;
		}
	}


	public class TestTwoRequestModel {}


	public class TestInputBaseModel {
		public string Email { get; set; }
		public string Name { get; set; }
	}

	public class TestTwoInputModel : TestInputBaseModel {}

	// Rules for inherited class properties.
	// * An empty value for Name results in StackOverflowException.
	// * A missing value for Name (no key POSTed with form data) results in StackOverflowException.
	public class TestTwoInputModelRules : ClassValidationRules<TestTwoInputModel> {
		public TestTwoInputModelRules() {
			Require(m => m.Name);

			Property(m => m.Name).MaximumLength(50);
			Property(m => m.Email).Email().MaximumLength(250);
		}
	}
}
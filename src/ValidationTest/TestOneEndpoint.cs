using FubuValidation;


namespace ValidationTest {
	public class TestOneEndpoint {
		public TestOneInputModel Get_Test_One(TestOneRequestModel request) {
			return new TestOneInputModel();
		}

		public TestOneInputModel Post_Test_One(TestOneInputModel input) {
			return input;
		}
	}


	public class TestOneRequestModel {}


	public class TestOneInputModel {
		public string Email { get; set; }
		public string Name { get; set; }
	}

	// Rules for direct class properties (no inheritance).
	// * An empty value for Name works as expected: Validation reports it as required.
	// * A missing value for Name (no key POSTed with form data) results in StackOverflowException.
	public class TestOneInputModelRules : ClassValidationRules<TestOneInputModel> {
		public TestOneInputModelRules() {
			Require(m => m.Name);

			Property(m => m.Name).MaximumLength(50);
			Property(m => m.Email).Email().MaximumLength(250);
		}
	}
}
require './string_utils'

RSpec.describe StringUtils do
  it "reverses a simple string" do
    expect(StringUtils.reverse_string("hello")).to eq("olleh")
  end

  it "reverses a string with spaces" do
    expect(StringUtils.reverse_string("hello world")).to eq("dlrow olleh")
  end

  it "returns an empty string if input is empty" do
    expect(StringUtils.reverse_string("")).to eq("")
  end
end


//rspec string_utils_spec.rb            correrlo

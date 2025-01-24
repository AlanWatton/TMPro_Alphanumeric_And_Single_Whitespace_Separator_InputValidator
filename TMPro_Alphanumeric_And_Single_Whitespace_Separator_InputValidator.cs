[Serializable]
[CreateAssetMenu(fileName = "InputValidator - Alphanumeric with Single Whitespace Separators", menuName = "TextMeshPro/Input Validators/Alphanumeric with Single Whitespace Separators", order = 100)]
public class TMPro_Alphanumeric_And_Single_Whitespace_Separator_InputValidator : TMP_InputValidator
{
	
	public override char Validate(ref string text, ref int pos, char ch)
	{
		if (char.IsLetterOrDigit(ch) || (char.IsWhiteSpace(ch) && !PreviousCharacterIsWhiteSpace(text, pos) && !NextCharacterIsWhiteSpace(text, pos)))
		{
			text = text.Insert(pos, ch.ToString());
			pos++;
			return ch;
		}
		
		return (char)0;
	}

	private bool PreviousCharacterIsWhiteSpace(string text, int pos)
	{
		return pos == 0 || pos > 0 && char.IsWhiteSpace(text[pos - 1]);
	}

	private bool NextCharacterIsWhiteSpace(string text, int pos)
	{
		return pos < text.Length && char.IsWhiteSpace(text[pos]);
	}
}

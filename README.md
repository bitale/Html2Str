# Html2Str
복잡한 HTML 문서를 String 변수에 대입하기 좋게 만듭니다. (Java, Javascript, C#..)
문자열을 +로 붙이는 곳에 사용할 수 있습니다.

예시 > 
text.html
<h1 style="font-size: 2rem; color: red;">Hello world!</h1>
<p>
  Lorem ipsum dolor sit amet, consectetur adipiscing elit,
  sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
  Ut enim ad minim veniam, quis nostrud exercitation ullamco
  laboris nisi ut aliquip ex ea commodo consequat.
</p>

변환후
text.txt, Clipboard
"<h1 style=\"font-size: 2rem; color: red;\">Hello world!</h1>" +
"<p>" +
"  Lorem ipsum dolor sit amet, consectetur adipiscing elit," +
"  sed do eiusmod tempor incididunt ut labore et dolore magna aliqua." +
"  Ut enim ad minim veniam, quis nostrud exercitation ullamco" +
"  laboris nisi ut aliquip ex ea commodo consequat." +
"</p>";

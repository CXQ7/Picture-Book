using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CHARACTERS;
using DIALOGUE;

namespace TESTING
{
    public class TestCharacters : MonoBehaviour
    {
        public GameObject dialogue;
        private Character CreateCharacter(string name) => CharacterManager.instance.CreateCharacter(name);
        // Start is called before the first frame update
        void Start()
        {
            //Character g = CharacterManager.instance.CreateCharacter("Generic");
            //Character r = CharacterManager.instance.CreateCharacter("Raelin");
            //Character fs2 = CharacterManager.instance.CreateCharacter("Female Student 2");
            //Character Miku = CharacterManager.instance.CreateCharacter("Miku");
            //Character Shishi = CharacterManager.instance.CreateCharacter("Shishi");
            //Character Hoshi = CharacterManager.instance.CreateCharacter("Hoshi");
            StartCoroutine(Test());
        }
        IEnumerator Test()
        {
            //Character_Sprite guard1 = CreateCharacter("Guard1 as Generic") as Character_Sprite;
            //Character_Sprite guard2 = CreateCharacter("Raelin") as Character_Sprite;
            ////Character_Sprite guard2 = CreateCharacter("Guard2 as Generic") as Character_Sprite;
            //Character_Sprite guard3 = CreateCharacter("Guard3 as Generic") as Character_Sprite;
            //Character_Live2D Mao = CreateCharacter("Mao") as Character_Live2D;
            //guard2.isVisible = false;
            //guard1.SetPosition(new Vector2(0.4f,0));
            //guard3.SetPosition(new Vector2(0.6f,0));
            //Mao.SetPosition(new Vector2(0.9f, 0));
            //yield return new WaitForSeconds(1);
            ////Mao.SetMotion("sample_01");
            //guard2.Show();
            //Sprite body = guard2.GetSprite("B2");
            //Sprite face = guard2.GetSprite("B_2");
            //guard2.SetSprite(body);
            //yield return guard2.TransitionSprite(face, 1);
            //yield return new WaitForSeconds(1);
            //Mao.SetExpression(4);
            //guard2.SetPriority(5);
            //guard1.SetPriority(1);
            //guard3.SetPriority(3);
            //guard2.Animate("Hop");
            //yield return new WaitForSeconds(1);
            //CharacterManager.instance.SortCharacters(new string[] { "guard3","guard2", "guard1" });
            //yield return new WaitForSeconds(1);
            //Mao.SetExpression("exp_02.exp3");
            //CharacterManager.instance.SortCharacters();
            //guard2.Animate("Shiver", true);
            //yield return new WaitForSeconds(1);
            ////Mao.SetMotion("special_01");
            //Mao.SetExpression("exp_01");
            //Mao.SetExpression(7);
            //guard2.Animate("Shiver", false);
            //CharacterManager.instance.SortCharacters(new string[] { "guard1", "guard2", "guard3" });
            //yield return guard2.Flip(0.03f);
            //guard2.SetColor(Color.red);
            ////guard2.layers[1].Setcolor(Color.green);
            //yield return guard2.TransitionColor(Color.green,speed:0.3f);
            //yield return guard2.TransitionColor(Color.blue);
            //guard2.TransitionSprite(guard2.GetSprite("B_3"), layer: 1);
            //yield return guard2.UnHighlight();
            //yield return new WaitForSeconds(1);
            //yield return guard2.FaceRight();
            //yield return guard2.Highlight();
            //yield return guard1.MoveToPosition(Vector2.one,smooth:true);
            //yield return guard3.MoveToPosition(Vector2.zero);
            //yield return new WaitForSeconds(1);
            //yield return guard2.FaceLeft(immediate:true);
            //guard1.Show();
            //guard3.Show();
            //Character r = CharacterManager.instance.CreateCharacter("Raelin");
            //yield return new WaitForSeconds(1f);
            //yield return r.Hide();
            //yield return new WaitForSeconds(0.5f);
            //yield return r.Show();
            //yield return guard1.Say("Hello World.");
            List<string> lines1 = new List<string>()
            {
                "����������ˤ�����ˣ����һƬ��ڣ���Ҷ����¼���",
                "���������ˣ�",
                "���������ˣ�",
                "����˽��������Ӻ��״�����",
                " "
            };
            yield return DialogueSystem.instance.Say(lines1);
            //VoiceControl.bgm[0].Play();
            dialogue.SetActive(false);
            Move1.isUp1 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);

            List<string> lines2 = new List<string>()
            {
                "����һͷ�Խ��󺣣������㺣�ˡ�",
                " "
            };
            yield return DialogueSystem.instance.Say(lines2);
            dialogue.SetActive(false);
            Move2.isUp2 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);
            //VoiceControl.bgm[0].Stop();
            //VoiceControl.bgm[1].Play();


            List<string> lines3 = new List<string>()
            {
                "����ʲô��",
                "����ʲô��",
                "��������",
                "���ף�һȺ��β�㷢����������",
                "����Ҫ�����ͻ�����ȥ��",
                " "
            };
            yield return DialogueSystem.instance.Say(lines3);
            dialogue.SetActive(false);
            Move3.isUp3 = true;
            yield return new WaitForSeconds(6f);
            dialogue.SetActive(true);

            List<string> lines4 = new List<string>()
            {
                "��Ⱥ����������������ȥ��",
                "�����Ĺ����������һƬ�ĺ��ס�",
                "��������Ϊʲô��ˤ����ѽ��",
                "��һ�����Ǹɵģ�",
                "�������Ĺ��˹���",
                "���ǣ�",
                "�������ٰ���ײ�����ˣ�",
                " "
            };
            yield return DialogueSystem.instance.Say(lines4);
            dialogue.SetActive(false);
            Move9.isUp9 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);


            List<string> lines5 = new List<string>()
            {
                "ˮĸȺ������������������������",
                " "
            };
            yield return DialogueSystem.instance.Say(lines5);
            dialogue.SetActive(false);
            Move4.isUp4 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);


            List<string> lines6 = new List<string>()
            {
                "�������ؼҵ�������������С����ͷ�ϡ�",
                "���������Ϻ�����",
                "����ѽ����̫�����Ʋ���������",
                "�����ɲ�Ҫȥ�����Ǹ���������ǣ�����������ײ������",
                "�����ܼǳ�",
                " "
            };
            yield return DialogueSystem.instance.Say(lines6);
            dialogue.SetActive(false);
            Move5.isUp5 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);
            //VoiceControl.bgm[1].Stop();
            //VoiceControl.bgm[0].Play();


            List<string> lines7 = new List<string>()
            {
                "һֻ���㷢����������",
                "��������������ȥ��",
                "�����С�������Ͻӹ�����������������ȥ��",
                "���Ӻ���һԾ���𣬽�����������ա�",
                "�����ģ�����Խ��Խ�ߣ�Խ��Խ�ߡ���",
                " "
            };
            yield return DialogueSystem.instance.Say(lines7);
            dialogue.SetActive(false);
            Move6.isUp6 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);


            List<string> lines8 = new List<string>()
            {
                "����������ȥ��",
                "������ʱ���߸ߵع�����ա�",
                " "
            };
            yield return DialogueSystem.instance.Say(lines8);
            dialogue.SetActive(false);
            Move7.isUp7 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);


            List<string> lines9 = new List<string>()
            {
                "���������ˣ�",
                "���������ˣ�",
                "�����ǴӸ���ˮ�棬�����������ſ��ֵ�Ц����",
                "*END*"
            };
            yield return DialogueSystem.instance.Say(lines9);
            //VoiceControl.bgm[0].Stop();
            dialogue.SetActive(false);
            Move8.isUp8 = true;
            yield return new WaitForSeconds(5f);
            dialogue.SetActive(true);

            yield return null;
            //Character Miku = CharacterManager.instance.CreateCharacter("Miku");
            //List<string> lines = new List<string>()
            //{
            //    "narrator \"A, Senbai.\"",
            //    "Ciallo.",
            //    "Ohaiyogosaimasu.",
            //    "Oh,{wa 1} ohaiyo."
            //};
            //List<string> lines = new List<string>()
            //{
            //    "A, Senbai.",
            //    "Ciallo.",
            //    "Ohaiyogosaimasu.",
            //    "Oh,{wa 1} ohaiyo."
            //};
            //yield return Miku.Say(lines);
            //Debug.Log("Finished");
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskTest.UI
{
    public class ExperimentControllerData
    {
        private static string[] AnswerSetGender = { "남자", "여자" };
        private static string[] AnswerSetSchool = { "초등학교", "중학교", "고등학교", "대학교" };
        private static string[] AnswerSetAddress = { "서울시", "수원시", "인천시", "화성시", "부천시", "분당", "송도", "기타" };
        private static string[] AnswerSetYesNo = { "있다", "없다" };
        private static string[] AnswerSetATM = { "예금인출","조회","계좌이체","입금","통장정리","무통장거래","휴대폰거래","신용카드","지로공과금","전자통장","분실신고","ENGLISH","캐시비","화면확대","부가서비스","다른업무"};
        private static string[] AnswerSetBank = { "국민은행", "기업은행", "신한은행", "하나은행", "우리은행", "외환은행", "농협", "새마을금고" };

        public ExperimentState[] States =
        {
            new ExperimentState("시작화면",
                "기표력 향상사업 실험", ExperimentContentType.Number,
                "실험자 번호", new string[0], 1, 2),
            new ExperimentState("실험 1-1",
                "귀하의 성별은 무엇입니까?", ExperimentContentType.MultipleSelection,
                "", AnswerSetGender, 1, 1),
            new ExperimentState("실험 1-2",
                "귀하의 최종학력은 무엇입니까?", ExperimentContentType.MultipleSelection,
                "", AnswerSetSchool, 1, 1),
            new ExperimentState("실험 1-3",
                "지금 살고 계시는 주거지는 어디입니까?", ExperimentContentType.MultipleSelectionWithRandom,
                "", AnswerSetAddress, 1, 1),
            new ExperimentState("실험 1-4",
                "귀하의 주민등록번호 앞 6자리 생년월일을 입력해 주세요.", ExperimentContentType.Number,
                "생년월일", new string[0], 1, 6),
            new ExperimentState("실험 1-5",
                "귀하가 주로 사용하시는 지하철 또는 전철 호선 번호를 두 개 입력해 주세요", ExperimentContentType.NumberWithRandom,
                "지하철 노선", new string[0], 2, 1),
            new ExperimentState("실험종료",
                "수고하셨습니다", ExperimentContentType.None,
                "", new string[0], 1, 1),
        };
    }
}

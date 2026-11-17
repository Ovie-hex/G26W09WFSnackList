using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace G26W09WFSnackList;

public class Database : DbContext
{
    public DbSet<Snack> Tuples { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // snacks.db 파일로 저장
        optionsBuilder.UseSqlite("Data Source=snacks.db");
    }

    public void AddInitSnack()
    {
        Tuples.AddRange(new Snack[]
        {
            new("블록스 피스 (Blox Fruits)", "열매 뽑기 10연속 꽝 나와서 멘탈 바사삭", "https://images.unsplash.com/photo-1490474418585-ba9bad8fd0ea?w=400&h=400&fit=crop"),
            new("입양하세요! (Adopt Me!)", "밤새 모은 재화로 전설 펫 부화 성공 기념", "https://images.unsplash.com/photo-1552053831-71594a27632d?w=400&h=400&fit=crop"),
            new("브룩헤이븐 RP (Brookhaven)", "시험 기간에 공부 안 하고 랜선 집들이 중", "https://images.unsplash.com/photo-1600210492486-724fe5c67fb0?w=400&h=400&fit=crop"),
            new("도어즈 (DOORS)", "문 99번 앞에서 러쉬(Rush) 소리 못 듣고 사망", "https://images.unsplash.com/photo-1518709268805-4e9042af9f23?w=400&h=400&fit=crop"),
            new("타워 오브 헬 (Tower of Hell)", "꼭대기 1칸 남기고 랙 걸려서 태초마을 추락", "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?w=400&h=400&fit=crop"),
            new("머더 미스터리 2 (MM2)", "10판 만에 겨우 머더 걸렸는데 시작하자마자 보안관한테 컷", "https://images.unsplash.com/photo-1509248961158-e54f6934749c?w=400&h=400&fit=crop"),
            new("베드워즈 (BedWars)", "침대 방어막 다 쳤는데 에메랄드 풀템 적팀 러쉬 옴", "https://images.unsplash.com/photo-1511512578047-dfb367046420?w=400&h=400&fit=crop"),
            new("자연재해 서바이벌", "높은 탑 꼭대기 올라갔는데 지진과 쓰나미 동시 발생", "https://images.unsplash.com/photo-1500375592092-40eb2168fd21?w=400&h=400&fit=crop"),
            new("펫 시뮬레이터 99", "자동 부화 켜놓고 자고 일어났더니 인벤토리 꽉 참", "https://images.unsplash.com/photo-1516731785388-d4c1a1b6f4a5?w=400&h=400&fit=crop"),
            new("드레스 투 임프레스 (DTI)", "런웨이 10초 남았는데 신발 색깔 못 맞춰서 꼴찌 확정", "https://images.unsplash.com/photo-1539109136881-3be0616acf4b?w=400&h=400&fit=crop"),
            new("블레이드 볼 (Blade Ball)", "1대1 최후의 대결에서 연타 싸움 패배 후 키보드 샷건", "https://images.unsplash.com/photo-1511882150382-421056c89033?w=400&h=400&fit=crop"),
            new("피기 (Piggy)", "출구 열쇠 다 찾았는데 문 앞에서 피기랑 정면으로 마주침", "https://images.unsplash.com/photo-1516467508483-a7212f5395b3?w=400&h=400&fit=crop"),
            new("벌 떼 시뮬레이터", "신화 벌 뽑으려고 로열 젤리 1만 개 순삭함", "https://images.unsplash.com/photo-1647427062468-74ff21e8934f?w=400&h=400&fit=crop"),
            new("로얄 하이 (Royale High)", "다이아몬드 노가다 3시간 뛰고 드디어 드림 스커트 구매", "https://images.unsplash.com/photo-1595777457583-95e059d581b8?w=400&h=400&fit=crop"),
            new("애니메이션 디펜스", "웨이브 50 보스 피 1% 남기고 기지 터짐", "https://images.unsplash.com/photo-1578632767115-351597cf2477?w=400&h=400&fit=crop"),
            new("피쉬 (Fisch)", "전설 물고기 입질 와서 집중하다가 마우스 미끄러짐", "https://images.unsplash.com/photo-1518837695005-2083093ee35b?w=400&h=400&fit=crop"),
            new("라이벌 (RIVALS)", "랭크전 승급전인데 상대팀에 에임 핵 고인물 만남", "https://images.unsplash.com/photo-1542751371-adc38448a05e?w=400&h=400&fit=crop"),
            new("아스날 (Arsenal)", "마지막 황금 칼 킬만 하면 우승인데 5분째 제자리걸음", "https://images.unsplash.com/photo-1593305841991-05c297ba4575?w=400&h=400&fit=crop"),
            new("3008 (이케아 생존기)", "밤이 되어서 직원이 쫓아오는데 기지 위치를 까먹음", "https://images.unsplash.com/photo-1600210492486-724fe5c67fb0?w=400&h=400&fit=crop"),
            new("워크 앳 어 피자 플레이스", "오븐에 피자 넣고 딴짓하다가 가게 전체 불태워 먹음", "https://images.unsplash.com/photo-1579751626657-72bc17010498?w=400&h=400&fit=crop")
        });

        // 실제로 데이터베이스에 저장
        SaveChanges();
    }
}

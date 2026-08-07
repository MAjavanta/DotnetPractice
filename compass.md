# Compass — not a roadmap

The bullets under **Keep in mind** are the constant. Everything below that is a **menu, not a march** — pick whatever pulls you right now, skip the rest guilt-free. You can't "fall off" a menu.

---

## Keep in mind (re-read this part every time)

- **Build → challenge → teach → repeat.** That's the whole loop.
- **One challenge per project.** Pick a single new thing to stretch on, ship, move on. Don't stack five hard things into one build.
- **Fundamentals by hand, AI off.** Learning = AI is a slot machine. Once you're confident = it's an accelerator. Not before.
- **Stay slightly uncomfortable.** Too easy → no growth. Too hard → you quit. Aim just above comfortable.
- **Teaching is networking.** Explaining what you just learned cements it *and* grows the network — same action.
- **Niche comes later.** Right now: get good, get a bit known. The niche crystallises once you have more reps. Don't force it early.
- **The chain:** be good → have evidence → earn trust → have a network → get into the right conversations → sell outcomes.

## The one habit that carries all of it

- **10 min/day, hands on keyboard, AI off.** Miss a day, resume the next. The streak is the point, not the length.

---

## Next few weeks (small on purpose)

One focus + one tiny public thing. That's it — kept small so it doesn't eat improvement time.

- **Focus:** CSS on freeCodeCamp. Sprinkle in a little Tailwind + React when CSS goes stale.
- **Apply it:** once some CSS is in hand, restyle *one screen* of the Habit Tracker — or a screen of Owed. Real application beats more tutorials.
- **Copy-a-UI drills (HTML + CSS only, no JS):** rebuild a real interface from a screenshot to force layout skills. Simple-ish but not trivial:
  - 3-tier **pricing page** (card grid, hover states, responsive) — flexbox/grid.
  - **Dashboard shell** (sidebar + top bar + card grid) — CSS grid, the meatiest.
  - **Calendar month grid** — grid layout, and directly reusable in the Habit Tracker.
  - **Kanban board** (columns of cards) — flexbox + overflow.
  - **Settings page** (tabs, toggles, form rows) — form layout + spacing.
- **Public, small:** one post a week on **LinkedIn** (~15 min, capped). "Thing I learned" or "bug that stumped me + the fix." Not a blog, not a course. See the LinkedIn section below.

---

## Branching paths (the menu)

### Fundamentals to deepen (any order, when the mood strikes)
- JS/TS for real — you're early; get properly comfortable.
- React fundamentals — hooks, state, component thinking.
- **Crafting Interpreters, in C#** — the deep one. How languages actually work. Big fundamentals payoff. Save for when you want something meaty.
- Testing — write tests for something you already built.
- **Python fundamentals** — you use it but "familiar", not fluent. Firm up the core: idioms, comprehensions, data structures, virtual envs, a bit of typing. Use your fbref/football projects as the practice ground.
- **Docker (longer-term — infra, not a language).** Best learned by containerising things you've *already* built. Concrete path:
  1. Write a Dockerfile for a .NET minimal API you've made (Owed's backend is ideal). Learn: image vs container, layers, `build`/`run`, ports.
  2. Add a **SQL Server container** and wire them together with docker-compose — directly relevant to your day job.
  3. Add a **volume** so the DB data survives a restart.
  4. From then on, containerise every new project as standing practice. That's the whole skill, learned on real apps.

### Projects to build in public (each carries ONE challenge)
- **Habit Tracker polish** → challenge: CSS/design.
- **Owed (invoice reminder)** → challenge: pick *one* — auth, or scheduled jobs + email sending, or a clean API. Don't make it carry all three at once.
- **Game-dev → YouTube matcher** → challenge: data wrangling / matching logic. Launch it as *"part two"* of the same mission, linked back to Owed.
- **Tiny tool of the month** → if you're in a wandering phase, lean in: build something small in a weekend, one new technique, ship, post. Turns the shiny-toy urge into reps instead of a fight. Ideas (each stretches one thing):
  - **DnD initiative tracker** (React) — component state; ties to your hobby.
  - **Dice roller with custom dice** (React or C#) — state + a bit of logic.
  - **Late-fee / invoice-number generator** (React) — form logic; feeds Owed.
  - **URL shortener** (.NET minimal API + SQLite) — routing, persistence, redirects.
  - **Markdown → HTML converter** (C#) — parsing.
  - **"Should I cycle today?" widget** (React + weather API) — consuming an external API.
  - **CSV → chart drop tool** (React) — file handling in the browser.
  - **fbref mini-dashboard** (Python) — data viz; builds on your football projects.
  - **Steam-tag scraper** (Python) — scraping/APIs; feeds the game-dev matcher.
  - **Wordle clone** (React or C#) — game state in a small box.

### Building in public on LinkedIn (current 2026 mechanics)
- **Personal profile, not a company page. Cadence: 1–2 posts/week to start** — quality over volume. Daily posting is dead and can now *hurt* reach.
- **Win the first 2–3 lines** (everything before "See more"). Dwell time is the #1 signal now — a hook that makes people stop and read is what earns reach.
- **No links in the post body** — LinkedIn suppresses them. Put the link in the *first comment* instead.
- **Write for saves and comments, not likes.** A save is worth several likes to the algorithm; a real comment far more. End posts with a genuine question to pull replies.
- **The "reply to 10 posts before & after you post" tactic — partly outdated.** The *spirit* is right (being active in the feed helps), but doing it as a mechanical ritual now looks like an engagement pod, which the 2026 algorithm penalises. The real version: leave *substantive* comments (15+ words, actually saying something) on others' posts a few times a week, spread out — not clustered around your own post, and never generic "Great post!" (counts as noise).
- **Formats that work:** plain-text posts and document carousels (both hold attention). Avoid formulaic AI-sounding phrasing — it's down-ranked.
- Content lives at the **person** level, and cross-link your projects across posts so they read as *one body of work under your name*, not scattered apps.

Formats that double as learning: "TIL", "bug + fix", "teach the concept I just learned like I'm explaining it to someone." Show stuck-then-unstuck, not just wins — most relatable, most useful to others.

### Network / showing up (Edinburgh — longer arc)
- Attend, don't host, at first. Just be a regular face.
- **Dev:** EdinburghJS, Edinburgh Software Developer MeetUp, IndieWeb Edinburgh (build-in-public crowd — literally your people).
- **Creator-side:** Creative Edinburgh (free tier), Creative Circles, GameDevEd Edinburgh (for the game-dev tool).
- **Founder/business:** Founders Hub, CodeBase events.
- **Referral seeds for later:** accountants/bookkeepers who serve freelancers; Business Gateway Edinburgh.

### Things to host (only once you've got reps + a bit of a name)
- Your "book club equivalent": a small recurring study/build group. Model it on IndieWeb's **Homebrew Website Club** — a handful of people show up, work on their own thing together, share progress. Low stakes, high consistency.
- A **Crafting Interpreters study group** — read it alongside 3–4 others, meet to compare. Teaching-by-doing + network in one.
- Later still: a small "tools for creators" session, co-hosted with an established group rather than solo.

---

## When you come back to this

1. Am I still doing 10 min/day?
2. Am I still posting once a week?
3. Which single branch pulls me right now? Pick it. Ignore the rest.

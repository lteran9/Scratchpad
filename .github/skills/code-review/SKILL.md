---
name: code-review
description: "Review C# changes in this repository for correctness, maintainability, and sound design. Use when asked for a code review applying YAGNI, SOLID, KISS, and DRY."
argument-hint: "Optional: specify files, a diff, or an area to review"
user-invocable: true
---

Review the requested changes in this repository. If the user names a scope, review that scope; otherwise review the current changes. Keep the review focused on code affected by the changes and inspect related callers and tests when needed to verify behavior. Do not modify files.

This is a learning and practice repository for data structures and algorithms in C#. Evaluate changes in that context: favor clear, understandable implementations that teach the underlying idea, while still expecting correct behavior and appropriate tests.

Look for meaningful issues using these principles:

- **Correctness first:** Check algorithmic behavior, edge cases, input assumptions, invariants, boundary conditions, and error handling. Verify that the implementation matches its documented or implied contract.
- **KISS:** Prefer the simplest clear solution. Flag unnecessary complexity, indirection, cleverness, or abstractions that make the code harder to understand.
- **YAGNI:** Flag speculative features, configuration, extensibility, or general-purpose machinery without a present requirement.
- **SOLID, applied pragmatically:** Look for responsibilities that are difficult to understand or change independently, inappropriate dependency direction, and abstractions that make substituting or extending behavior harder. Do not demand interfaces, patterns, or extra layers without a concrete benefit.
- **DRY, applied carefully:** Flag duplicated logic when it creates a real risk of inconsistent behavior. Do not recommend merging code merely because it looks similar if the concepts or likely reasons to change differ.
- **Algorithm and performance suitability:** Check time and space complexity, termination, recursion depth, and avoidable allocations against the operation's purpose and expected input. Do not prioritize micro-optimizations over clarity without evidence they matter.
- **Maintainability and idiomatic C#:** Check naming, types, nullability, accessibility, resource ownership, and consistency with nearby code. Avoid style-only feedback unless it creates ambiguity or a maintenance risk.
- **Tests:** Check whether tests cover important behavior, boundaries, and regressions, and whether assertions actually distinguish correct from incorrect results. Avoid requesting redundant tests.

Report only actionable issues introduced by the changes. Do not report pre-existing problems, speculative concerns, preferences, or issues that cannot be tied to specific code. Before reporting a concern, inspect enough relevant implementation and test context to confirm it. If no actionable issues are found, say so plainly.

Order findings by severity, then confidence. For each finding, include a concise title, severity (`Critical`, `High`, `Medium`, or `Low`), confidence from 1–10, file and line number(s), the concrete impact, and a specific suggested direction for fixing it. Keep findings focused and do not include praise or a general code summary.

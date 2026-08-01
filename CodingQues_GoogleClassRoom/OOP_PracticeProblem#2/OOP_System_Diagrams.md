# Object Modeling Diagrams & Comparative Analysis

This document provides visual modeling diagrams (Class, Object, and Sequence diagrams) for the **School Results Application** and **Grocery Store Bill Generation Application**, highlighting the difference between **Aggregation** and **Composition**.

---

## 1. School Results Application (Aggregation)

### 📐 Class Diagram
In this scenario, a `StudentResult` has an **aggregation** relationship (`o--`) with `SchoolSubject`. The subject objects exist independently of any specific student. `GradeCalculator` interacts with `StudentResult` to compute results.

```mermaid
classDiagram
    class StudentResult {
        +string Name
        +List~SchoolSubject~ Subjects
        +AddSubject(SchoolSubject subject)
    }
    class SchoolSubject {
        +string Name
        +double Marks
    }
    class GradeCalculator {
        +CalculateAverage(StudentResult student) double
        +CalculateGrade(double average) string
        +DisplayReport(StudentResult student)
    }

    StudentResult "1" o-- "many" SchoolSubject : Aggregation
    GradeCalculator ..> StudentResult : Computes Result For
```

### 📦 Object Diagram
Represents the runtime instance state where student **John** is aggregated with two subjects: **Maths** (90) and **Science** (85).

```mermaid
graph TD
    subgraph "Runtime Object State"
        J["John : StudentResult"]
        M["Maths : SchoolSubject<br/>Marks = 90"]
        S["Science : SchoolSubject<br/>Marks = 85"]
        GC["calc : GradeCalculator"]
    end
    J -- "aggregates" --> M
    J -- "aggregates" --> S
    GC -. "computes grade for" .-> J
```

### 🔄 Sequence Diagram
Shows the interaction flow when a student requests their grade report.

```mermaid
sequenceDiagram
    autonumber
    actor Student as John (Student)
    participant Calc as GradeCalculator
    participant Sub1 as Maths (Subject)
    participant Sub2 as Science (Subject)

    Student->>Calc: DisplayReport(student)
    activate Calc
    Calc->>Sub1: Read Marks (90)
    Calc->>Sub2: Read Marks (85)
    Calc->>Calc: CalculateAverage() -> 87.5
    Calc->>Calc: CalculateGrade(87.5) -> "A"
    Calc-->>Student: Print Report (Avg: 87.5, Grade: A)
    deactivate Calc
```

---

## 2. Grocery Store Bill Generation Application (Composition)

### 📐 Class Diagram
In this scenario, `GroceryCustomer` has a **composition** relationship (`*--`) with `GroceryProduct`. The purchased products are created specifically for the customer's transaction and cannot exist independently of the purchase context.

```mermaid
classDiagram
    class GroceryCustomer {
        +string Name
        +List~GroceryProduct~ PurchasedProducts
        +PurchaseProduct(string name, double quantity, double unitPrice)
    }
    class GroceryProduct {
        +string Name
        +double Quantity
        +double UnitPrice
        +GetTotalPrice() double
    }
    class BillGenerator {
        +CalculateTotal(GroceryCustomer customer) double
        +GenerateBill(GroceryCustomer customer)
    }

    GroceryCustomer "1" *-- "many" GroceryProduct : Composition
    BillGenerator ..> GroceryCustomer : Generates Bill For
```

### 📦 Object Diagram
Represents the runtime instance state where customer **Alice** owns two purchased products: **Apples** (2 kg @ $3) and **Milk** (1 L @ $2).

```mermaid
graph TD
    subgraph "Runtime Object State"
        A["Alice : GroceryCustomer"]
        P1["Apples : GroceryProduct<br/>2 kg @ $3/kg = $6.00"]
        P2["Milk : GroceryProduct<br/>1 L @ $2/L = $2.00"]
        BG["gen : BillGenerator"]
    end
    A -- "owns (composition)" --> P1
    A -- "owns (composition)" --> P2
    BG -. "generates bill for" .-> A
```

### 🔄 Sequence Diagram
Shows the interaction flow when a customer checks out and the total bill is calculated.

```mermaid
sequenceDiagram
    autonumber
    actor Customer as Alice (Customer)
    participant BG as BillGenerator
    participant P1 as Apples (Product)
    participant P2 as Milk (Product)

    Customer->>BG: GenerateBill(customer)
    activate BG
    BG->>P1: GetTotalPrice() -> $6.00
    BG->>P2: GetTotalPrice() -> $2.00
    BG->>BG: CalculateTotal() -> $8.00
    BG-->>Customer: Output Checkout Bill ($8.00)
    deactivate BG
```

---

## 📊 Comparison of Scenarios

| Feature | School Results Application | Grocery Store Bill Application |
| :--- | :--- | :--- |
| **Classes** | `StudentResult`, `SchoolSubject`, `GradeCalculator` | `GroceryCustomer`, `GroceryProduct`, `BillGenerator` |
| **Relationship Type** | **Aggregation** (`o--`) | **Composition** (`*--`) |
| **Lifecycle Dependency** | Subjects exist independently of students. | Products in cart are tied to the purchase transaction. |
| **Primary Functionality** | Calculate average marks and final grade | Compute total purchase cost and generate checkout bill |
| **Key Entities** | Students, Subjects, Grades | Customers, Products, Bills |
